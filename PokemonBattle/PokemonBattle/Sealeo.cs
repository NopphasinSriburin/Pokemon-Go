using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Sealeo : Pokemon
    {
        public Sealeo()
        {
            Random random = new Random();
            Name = "Sealeo";
            HP = random.Next(123, 182);
            _image = Properties.Resources.Sealeo;
            Attack = random.Next(32, 43);
            Defense = random.Next(12, 32);
        }
    }
}
