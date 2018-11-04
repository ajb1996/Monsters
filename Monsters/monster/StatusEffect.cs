using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.monster
{
    class StatusEffect
    {
        public double dChance { get; set; }
        public EffectType oEffectType { get; set; }

    }

    public enum EffectType
    {
        POISON, SLEEP, PARALYSIS, FREEZE, CONFUSE, NONE
    }
}
