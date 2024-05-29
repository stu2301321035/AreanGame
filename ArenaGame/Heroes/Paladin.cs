using ArenaGame;
using System;

public class Paladin : Hero
{

    public Paladin(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
    {
    }

    public override double Attack()
    {
        double damage = base.Attack()*1.1;

        double critHit = 0.05;
        if (random.NextDouble()<critHit)
        {
            Console.WriteLine($"{Name} lands a critical hit with Holy Strike!");
            damage *= 1.5;
        }
        return damage;
    }

    public override double Defend(double damage)
    {
        double reducedDamage = damage * 0.85;

        double blockChance = 0.05;
        if (random.NextDouble()<blockChance)
        {
            Console.WriteLine($"{Name} blocks the incoming attack with Shield of Virtue!");
            reducedDamage = 0; 
        }
        return reducedDamage;

    }
}
