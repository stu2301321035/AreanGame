using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; } 
        double BlockingPower { get; }
        double LifeSteal { get; } // позволява на героя да възстановява малка част от живота си при всяка успешна атака.
        double SheildBreaker { get; } //нанася повече щети на врагове с броня, пробивайки защитата им по-лесно.
    }
}
