using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonBattle
{
    internal class Nidoking : Pokemon
    {
        public Nidoking()
        {
            Random random = new Random();
            Name = "Nidoking";
            HP = random.Next(56, 245);
            _image = Properties.Resources.Nidoking;
            Attack = random.Next(40, 72);
            Defense = random.Next(10, 25);
        }
    }
}
