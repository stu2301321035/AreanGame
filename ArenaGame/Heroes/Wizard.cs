using ArenaGame;
using System;

public class Wizzard : Hero
{
    private double magicalPower;
    public Wizzard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
    {
        magicalPower = 100;
    }

    public override double Attack()
    {
        double damage = base.Attack();
        if (magicalPower>=25)
        {
            damage += 25;
            magicalPower -= 25;

        }
        return damage;
    }

    public override double Defend(double damage)
    {
        double magicPowerShield = 50;
        if (magicalPower> magicPowerShield)
        {
            double reduction = Math.Min(magicalPower/2,damage);
            magicalPower -= reduction * 2;
            Console.WriteLine($"{Name} activates Mana Shield, reducing damage by {reduction}!");
            return damage - reduction;

        }
        return base.Defend(damage);
    }
}
