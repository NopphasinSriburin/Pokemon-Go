using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Gengar
    {
        protected string Name = "Gengar";
        protected int HP = 140;
        protected int AT = 20;
        private Bitmap _image = global::Pokemon.Properties.Resources.Gengar;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return Name; }
        public int getHP() { return HP; }
        public int getAT() { return AT; }
    }
}
