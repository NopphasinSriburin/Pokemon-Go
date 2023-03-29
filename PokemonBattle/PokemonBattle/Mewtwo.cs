using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            Random random = new Random();
            Name = "Mewtwo";
            HP = random.Next(141, 221);
            _image = Properties.Resources.Mewtwo;
            Attack = random.Next(23, 34);
            Defense = random.Next(11, 27);
        }
    }
}
