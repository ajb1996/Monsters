using Monsters.core;

namespace Monsters.monster
{
    public class Move
    {
        public StatusEffect oEffect { get; set; }
        public string sName { get; set; }
        public int iDamage { get; set; }
        public Enums.Type oType { get; set; }
        public StatEffect oStatEffect { get; set; }

        public Move(StatusEffect oEffect, string sName, int iDamage, Enums.Type oType, StatEffect oStatEffect)
        {
            this.oEffect = oEffect;
            this.sName = sName;
            this.iDamage = iDamage;
            this.oType = oType;
        }

    }

    public class StatEffect
    {
        public readonly StatsList oStatsAffected;
        public Enums.Target oTarget;

        public StatEffect(StatsList oStatsAffected)
        {
            this.oStatsAffected = oStatsAffected;
        }
    }
}
