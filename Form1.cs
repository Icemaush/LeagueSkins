using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

/* Name: LeagueSkins
 * Author: Icemaush
 * Date: 11/04/2020
 * Version: 1.0.0
 */

namespace LeagueSkins
{
    public partial class LeagueSkins : Form
    {
        string versionUrl = "https://ddragon.leagueoflegends.com/api/versions.json";
        string version;
        JObject champ;
        string SelectedChamp;
        string champId;
        List<string> champList = new List<string>();
        Dictionary<string, string> champDict = new Dictionary<string, string>();
        List<Skin> skinList = new List<Skin>();
        Skin currentSkin;
        int skinIndex;
        int totalSkins;
        private delegate void ShowLoadingBarDelegate();
        private delegate void IncrementLoadingBarDelegate();
        private delegate void HideLoadingBarDelegate();
        private delegate void UpdatePictureBoxDelegate();
        Thread thread;

        public LeagueSkins()
        {
            version = GetVersion(versionUrl);
            string champsUrl = "http://ddragon.leagueoflegends.com/cdn/" + version + "/data/en_US/champion.json";

            InitializeComponent();

            GetChamps(champsUrl);
        }

        private string GetVersion(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var versionJson = wc.DownloadString(url);
                JArray versionList = JArray.Parse(versionJson);
                string latestVersion = versionList[0].ToString();
                wc.Dispose();
                return latestVersion;
            }
        }

        private void GetChamps(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var champsJson = wc.DownloadString(url);
                JObject champs = JObject.Parse(champsJson);

                champList.Add(" Select a champion");
                foreach (var key in champs["data"].Children().Children())
                {
                    champDict.Add(key["name"].ToString(), key["id"].ToString());
                    champList.Add(key["name"].ToString());
                }

                champList.Sort();
                comboBox1.DataSource = champList;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Color color1 = Color.FromArgb(7, 31, 45);
            Color color2 = Color.FromArgb(2, 12, 22);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 290F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                btnLeft.Enabled = true;
                btnRight.Enabled = true;
                if (thread != null)
                {
                    thread.Abort();
                }
                SelectedChamp = comboBox1.SelectedItem.ToString();
                champId = champDict[comboBox1.SelectedItem.ToString()];
                string champUrl = "http://ddragon.leagueoflegends.com/cdn/" + version + "/data/en_US/champion/" + champId + ".json";
                using (WebClient wc = new WebClient())
                {
                    var champJson = wc.DownloadString(champUrl);
                    champ = JObject.Parse(champJson);
                }
                thread = new Thread(new ThreadStart(GetSkins));
                thread.Start();
            }
        }

        private void GetSkins()
        {
            var d1 = new ShowLoadingBarDelegate(ShowLoadingBar);
            loadingBar.Invoke(d1);

            skinList.Clear();
            skinIndex = 0;
            totalSkins = 0;

            using (var wc = new WebClient())
            {
                foreach (var key in champ["data"][champId]["skins"])
                {
                    totalSkins++;

                    var d2 = new IncrementLoadingBarDelegate(IncrementLoadingBar);
                    loadingBar.Invoke(d2);

                    // Create Skin object and set attributes for each skin from json.
                    Skin skin = new Skin();
                    skin.Id = Convert.ToInt32(key["num"].ToString());

                    if (skin.Id == 0)
                    {
                        skin.Name = SelectedChamp;
                    }
                    else
                    {
                        skin.Name = key["name"].ToString();
                    }

                    skin.Url = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/" + champId + "_" + skin.Id + ".jpg";

                    using (var imgStream = new MemoryStream(wc.DownloadData(skin.Url)))
                    {
                        skin.Image = Image.FromStream(imgStream);
                    }

                    skinList.Add(skin);

                    if (skinList[0] != null)
                    {
                        UpdateCurrentSkin(skinIndex);
                    }
                }
            }

            var d3 = new HideLoadingBarDelegate(HideLoadingBar);
            loadingBar.Invoke(d3);

            var d4 = new UpdatePictureBoxDelegate(UpdateControls);
            pictureBox1.Invoke(d4);
        }

        private void UpdateControls()
        {
            pictureBox1.Image = currentSkin.Image;
            lblSkinName.Text = currentSkin.Name;
            lblSkinCount.Text = (skinIndex + 1) + " / " + totalSkins;
        }

        private void ShowLoadingBar()
        {
            loadingBar.Show();
            int skinCount = 0;
            foreach (var key in champ["data"][champId]["skins"])
            {
                skinCount++;
            }
            loadingBar.Maximum = skinCount;
            loadingBar.Value = 0;
        }

        private void IncrementLoadingBar()
        {
            loadingBar.Increment(1);
        }

        private void HideLoadingBar()
        {
            loadingBar.Hide();
        }

        private void LeagueSkins_Load(object sender, EventArgs e)
        {
            btnLeft.Parent = pictureBox1;
            btnRight.Parent = pictureBox1;
            loadingBar.Parent = pictureBox1;
            CenterHorizontally(loadingBar);
        }

        private void CenterHorizontally(Control control)
        {
            Rectangle parentRect = control.Parent.ClientRectangle;
            control.Left = (parentRect.Width - control.Width) / 2;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (skinList.Count > 0)
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    if (skinIndex + 1 >= skinList.Count)
                    {
                        skinIndex = 0;
                    }
                    else
                    {
                        skinIndex++;
                    }
                    UpdateCurrentSkin(skinIndex);
                    UpdateControls();
                }
            }
        }

        private void btnRight_MouseEnter(object sender, EventArgs e)
        {
            btnRight.Image = Properties.Resources.rightarrow;
        }

        private void btnRight_MouseLeave(object sender, EventArgs e)
        {
            btnRight.Image = null;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (skinList.Count > 0)
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    if (skinIndex - 1 < 0)
                    {
                        skinIndex = skinList.Count - 1;
                    }
                    else
                    {
                        skinIndex--;
                    }
                    UpdateCurrentSkin(skinIndex);
                    UpdateControls();
                }
            }
        }

        private void btnLeft_MouseEnter(object sender, EventArgs e)
        {
            btnLeft.Image = Properties.Resources.leftarrow;
        }

        private void btnLeft_MouseLeave(object sender, EventArgs e)
        {
            btnLeft.Image = null;
        }

        private void UpdateCurrentSkin(int index)
        {
            currentSkin = skinList[index];

        }
    }
}
