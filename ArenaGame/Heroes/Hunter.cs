using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
	public class Hunter:Hero
	{
        private int arrowCount;
        public Hunter(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            arrowCount = 10;
        }

        public override double Attack()
        {
           double damage = base.Attack();

            if (arrowCount>=2)
            {
                damage *= 3;
                arrowCount -= 2;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            if (random.NextDouble() < 0.20)
            {
                Console.WriteLine($"{Name} evades the attack!");
                return 0;
            }


            return base.Defend(damage);
        }
    }
}



