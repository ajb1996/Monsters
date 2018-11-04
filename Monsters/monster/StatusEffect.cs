using Monsters.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.monster
{
    public class StatusEffect
    {
        public double dChance { get; set; }
        public Enums.EffectType oEffectType { get; set; }


        public StatusEffect(double dChancem,Enums.EffectType oEffectType)
        {
            this.dChance = dChance;
            this.oEffectType = oEffectType;
        }
    }
}
