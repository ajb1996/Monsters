using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.core;

namespace Monsters.monster
{
    public class Monster
    {
        public String sName { get; set; }
        public int iHealth { get; set; }
        public List<Move> oMoves = new List<Move>();
        public Enums.EffectType oCurrentEffect { get; set; }
        public bool bFainted = false;
        public StatsManager oStats;

        public Monster(String sName, int iHealth, List<Move> oMoves, Enums.EffectType oEffectType, StatsManager oStats)
        {
            this.sName = sName;
            this.iHealth = iHealth;
            this.oMoves = oMoves;
            this.oCurrentEffect = oEffectType;
            this.bFainted = false;
            this.oStats = oStats;
        }
        public void AddMove(Move m)
        {
            if (oMoves.Count <= 4)
            {
                oMoves.Add(m);
            }
        }
    }

    public class StatsManager
    {
        private StatsList oBaseline;
        private StatsList oModifiers = new StatsList();

        public StatsManager(int a, int d, int s, int ac, int sa, int sd) => oBaseline = new StatsList(a, d, s, ac, sa, sd);

        public StatsManager(StatsList s) => oBaseline = s;

        public int GetStat(Enums.StatName oStatToGet, bool bModified)
        {
            switch (oStatToGet)
            {
                case Enums.StatName.ATTACK:
                    return bModified ? oBaseline.iAttack += oModifiers.iAttack : oBaseline.iAttack;

                case Enums.StatName.DEFENCE:
                    return bModified ? oBaseline.iDefence += oModifiers.iDefence : oBaseline.iDefence;

                case Enums.StatName.SPEED:
                    return bModified ? oBaseline.iSpeed += oModifiers.iSpeed : oBaseline.iSpeed;

                case Enums.StatName.ACCURACY:
                    return bModified ? oBaseline.iAccuracy += oModifiers.iAccuracy : oBaseline.iAccuracy;

                case Enums.StatName.SPECIALATTACK:
                    return bModified ? oBaseline.iSpecialAttack += oModifiers.iSpecialAttack : oBaseline.iSpecialAttack;

                case Enums.StatName.SPECIALDEFENCE:
                    return bModified ? oBaseline.iSpecialDefence += oModifiers.iSpecialDefence : oBaseline.iSpecialDefence;
            }

            return 0;
        }

        public void ApplyStatChanges(StatsList toApply)
        {
            oModifiers.iAccuracy += toApply.iAccuracy;
            oModifiers.iAttack += toApply.iAttack;
            oModifiers.iDefence += toApply.iDefence;
            oModifiers.iSpecialAttack += toApply.iSpecialAttack;
            oModifiers.iSpecialDefence += toApply.iSpecialDefence;
            oModifiers.iSpeed += toApply.iSpeed;
        }

    }

    public class StatsList
    {
        public int iAttack;
        public int iDefence;
        public int iSpeed;
        public int iAccuracy;
        public int iSpecialAttack;
        public int iSpecialDefence;

        public StatsList()
        {
            iAttack = 0;
            iDefence = 0;
            iSpeed = 0;
            iAccuracy = 0;
            iSpecialAttack = 0;
            iSpecialDefence = 0;
        }

        public StatsList(int a, int d, int s, int ac, int sa, int sd)
        {
            iAttack = a;
            iDefence = d;
            iSpeed = s;
            iAccuracy = ac;
            iSpecialAttack = sa;
            iSpecialDefence = sd;
        }
    }

    
}
