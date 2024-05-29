using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strenght { get; private set; }
        public IWeapon Weapon { get; private set; }
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }


        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = Strenght + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);

            if (Weapon.LifeSteal>0)
            {
                double lifeStealAmount = realDamage * Weapon.LifeSteal;
                Health+= lifeStealAmount;
                Console.WriteLine($"{Name} restored {Math.Round(lifeStealAmount, 2)} health with Life Steal.");  
            }
            return realDamage;
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double adjustedArmor = Armor;
            if (Weapon.SheildBreaker > 0)
            {
                adjustedArmor = Armor * (1 - Weapon.SheildBreaker);
                Console.WriteLine($"{Name}'s armor reduced to {Math.Round(adjustedArmor, 2)} due to Shield Breaker.");
            }

            double defendPower = (adjustedArmor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
