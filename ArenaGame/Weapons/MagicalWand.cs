using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicalWand : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double LifeSteal { get; private set; }

        public double SheildBreaker { get; private set; }

        public MagicalWand(string name)
        {
            Name = name;
            AttackDamage = 5;
            BlockingPower = 10;
            LifeSteal = 0.1;
            SheildBreaker = 0.08;
        }
    }
}
