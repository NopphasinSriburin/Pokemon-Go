using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Sealeo
    {
        protected string Name = "Sealeo";
        protected int HP = 130;
        protected int AT = 15;
        private Bitmap _image = global::Pokemon.Properties.Resources.Sealeo;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return Name; }
        public int getHP() { return HP; }
        public int getAT() { return AT; }
    }
}
