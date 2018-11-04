using Monsters.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.monster
{
    public class Move
    {
        public StatusEffect oEffect { get; set; }
        public string sName { get; set; }
        public int iDamage { get; set; }
        public Enums.Type oType { get; set; }


        public Move(StatusEffect oEffect, string sName,int iDamage, Enums.Type oType)
        {
            this.oEffect = oEffect;
            this.sName = sName;
            this.iDamage = iDamage;
            this.oType = oType;
        }
    }
}
