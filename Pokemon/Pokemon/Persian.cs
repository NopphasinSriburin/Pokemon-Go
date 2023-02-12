using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Persian
    {
        protected string Name = "Persian";
        protected int HP = 240;
        protected int AT = 30;
        private Bitmap _image = global::Pokemon.Properties.Resources.Persian;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return Name; }
        public int getHP() { return HP; }
        public int getAT() { return AT; }
    }
}
