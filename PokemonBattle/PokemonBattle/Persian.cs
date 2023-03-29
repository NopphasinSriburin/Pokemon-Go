using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Persian : Pokemon
    {
        public Persian()
        {
            Random random = new Random();
            Name = "Persian";
            HP = random.Next(188, 282);
            _image = Properties.Resources.Persian;
            Attack = random.Next(98, 223);
            Defense = random.Next(81, 203);
        }
    }
}
