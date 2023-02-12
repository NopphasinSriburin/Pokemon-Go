using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class BattlePokemon
    {
        protected string Name = "Gengar";
        protected int HP = 40;
        protected int AT = 120;

        public string getName (){ return Name; }
        public int getHP() { return HP; }
        public int getAT() { return AT; }
    }
}
