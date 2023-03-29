using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Gengar : Pokemon
    {
        public Gengar()
        {
            Random random = new Random();
            Name = "Gengar";
            HP = random.Next(122, 168);
            _image = Properties.Resources.Gengar;
            Attack = random.Next(11, 25);
            Defense = random.Next(5, 7);
        }
    }
}
