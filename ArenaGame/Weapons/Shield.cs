using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Shield : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeSteal { get; private set; }

        public double SheildBreaker { get; private set; }

        public Shield(string name)
        {
            Name = name;
            AttackDamage = 5;
            BlockingPower = 15;
            LifeSteal = 0;
            SheildBreaker = 0.1;
        }
    }
}
