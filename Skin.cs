using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LeagueSkins
{
    class Skin
    {
        private int id;
        private string name;
        private string url;
        private Image image;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
