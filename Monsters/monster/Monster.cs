﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.monster
{
    class Monster
    {
        public String sName { get; set; }
        public int iHealth { get; set; }
        public List<Move> oMoves = new List<Move>();
        public EffectType oCurrentEffect { get; set; }
        public bool bFainted;
        public void AddMove(Move m)
        {
            if (oMoves.Count <= 4)
            {
                oMoves.Add(m);
            }
        }
    }

    class StatsManager
    {
        private StatsList oBaseline;
        private StatsList oModifiers;

        StatsManager(int a, int d, int s, int ac, int sa, int sd)
        {
            baseline = new StatsList();

        }

        StatsManager(StatsList s)
        {
            baseline = s;
        }

        public getStat(StatName oStatToGet, bool bModified)
        {
            switch (oStatToGet)
            {
                case StatName.ATTACK:
                    return bModified ? oBaseline.iAttack += oModifiers.iAttack : oBaseline.iAttack;
                    break;
                case StatName.DEFENCE:
                    return bModified ? oBaseline.iDefence += oModifiers.iDefence : oBaseline.iDefence;
                    break;
                case StatName.SPEED:
                    return bModified ? oBaseline.iSpeed += oModifiers.iSpeed : oBaseline.iSpeed;
                    break;
                case StatName.ACCURACY:
                    return bModified ? oBaseline.iAccuracy += oModifiers.iAccuracy : oBaseline.iAccuracy;
                    break;
                case StatName.SPECIALATTACK:
                    return bModified ? oBaseline.iSpecialAttack += oModifiers.iSpecialAttack : oBaseline.iSpecialAttack;
                    break;
                case StatName.SPECIALDEFENCE:
                    return bModified ? oBaseline.iSpecicalDefence += oModifiers.iSpecicalDefence : oBaseline.iSpecicalDefence;
                    break;
            }
        }

    }

    class StatsList
    {
        public int iAttack;
        public int iDefence;
        public int iSpeed;
        public int iAccuracy;
        public int iSpecialAttack;
        public int iSpecicalDefence;
    }

    enum StatName
    {
        ATTACK, DEFENCE, SPEED, ACCURACY, SPECIALATTACK, SPECIALDEFENCE
    }
}
