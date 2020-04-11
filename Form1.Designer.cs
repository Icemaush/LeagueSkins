namespace LeagueSkins
{
    partial class LeagueSkins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblSelectChamp = new System.Windows.Forms.Label();
            this.lblSkinName = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSkinCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("BeaufortforLOL-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(167)))), ((int)(((byte)(117)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 26;
            this.comboBox1.Location = new System.Drawing.Point(978, 13);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 34);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.Enabled = false;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.Color.Transparent;
            this.btnRight.Location = new System.Drawing.Point(1131, 10);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(119, 824);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseEnter += new System.EventHandler(this.btnRight_MouseEnter);
            this.btnRight.MouseLeave += new System.EventHandler(this.btnRight_MouseLeave);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeft.Enabled = false;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeft.Location = new System.Drawing.Point(10, 10);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(121, 824);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseEnter += new System.EventHandler(this.btnLeft_MouseEnter);
            this.btnLeft.MouseLeave += new System.EventHandler(this.btnLeft_MouseLeave);
            // 
            // lblSelectChamp
            // 
            this.lblSelectChamp.AutoSize = true;
            this.lblSelectChamp.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectChamp.Font = new System.Drawing.Font("BeaufortforLOL-Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChamp.ForeColor = System.Drawing.Color.Tan;
            this.lblSelectChamp.Location = new System.Drawing.Point(798, 16);
            this.lblSelectChamp.Name = "lblSelectChamp";
            this.lblSelectChamp.Size = new System.Drawing.Size(174, 28);
            this.lblSelectChamp.TabIndex = 19;
            this.lblSelectChamp.Text = "Select champion:";
            // 
            // lblSkinName
            // 
            this.lblSkinName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSkinName.BackColor = System.Drawing.Color.Transparent;
            this.lblSkinName.Font = new System.Drawing.Font("BeaufortforLOL-Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkinName.ForeColor = System.Drawing.Color.Tan;
            this.lblSkinName.Location = new System.Drawing.Point(22, 794);
            this.lblSkinName.Name = "lblSkinName";
            this.lblSkinName.Size = new System.Drawing.Size(1215, 28);
            this.lblSkinName.TabIndex = 20;
            this.lblSkinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingBar
            // 
            this.loadingBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingBar.ForeColor = System.Drawing.Color.DarkRed;
            this.loadingBar.Location = new System.Drawing.Point(427, 37);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(400, 10);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 21;
            this.loadingBar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::LeagueSkins.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(22, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1215, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblSkinCount
            // 
            this.lblSkinCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSkinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSkinCount.Font = new System.Drawing.Font("BeaufortforLOL-Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkinCount.ForeColor = System.Drawing.Color.Tan;
            this.lblSkinCount.Location = new System.Drawing.Point(1107, 794);
            this.lblSkinCount.Name = "lblSkinCount";
            this.lblSkinCount.Size = new System.Drawing.Size(130, 28);
            this.lblSkinCount.TabIndex = 22;
            this.lblSkinCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LeagueSkins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1260, 844);
            this.Controls.Add(this.lblSkinCount);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.lblSkinName);
            this.Controls.Add(this.lblSelectChamp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::LeagueSkins.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeagueSkins";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "LeagueSkins";
            this.Load += new System.EventHandler(this.LeagueSkins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblSelectChamp;
        private System.Windows.Forms.Label lblSkinName;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSkinCount;
    }
}

