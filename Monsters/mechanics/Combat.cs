using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.monster;
using Monsters.core;
namespace Monsters.mechanics
{
    public class Combat
    {
        public Team player1 = new Team();
        public Team player2 = new Team();

        public Combat()
        {
#if DEBUG
            InitialiseTeams();
#endif
            Monster current = player1.GetMonsterAt(0);
            player1.SetCurrent(ref current);
            current = player2.GetMonsterAt(0);
            player2.SetCurrent(ref current);

        }

        public void ApplyMove(ref Monster p, Move m)
        {
            if (m.oEffect.oEffectType != Enums.EffectType.NONE && p.oCurrentEffect == Enums.EffectType.NONE)
            {
                if (new Random().NextDouble() < m.oEffect.dChance)
                {
                    p.oCurrentEffect = m.oEffect.oEffectType;
                }
            }
            p.iHealth -= m.iDamage;
        }
#if DEBUG
        private void InitialiseTeams()
        {
            List<Move> moves = new List<Move>
            {
                new Move(new StatusEffect(0, Enums.EffectType.NONE), "Tackle", 30, Enums.Type.NORMAL),
                new Move(new StatusEffect(0, Enums.EffectType.NONE), "Growl", 30, Enums.Type.NORMAL),
                new Move(new StatusEffect(0, Enums.EffectType.NONE), "Tail Whip", 30, Enums.Type.NORMAL),
                new Move(new StatusEffect(50, Enums.EffectType.CONFUSE), "Water Gun", 30, Enums.Type.WATER)
            };
            player1.oMonsters.Add(new Monster("TestMonster", 100, moves, Enums.EffectType.NONE, new StatsManager(10, 10, 10, 10, 10, 10)));
            player2.oMonsters.Add(new Monster("TestMonster2", 100, moves, Enums.EffectType.NONE, new StatsManager(10, 10, 10, 10, 10, 10)));
        }
#endif
    }

    public class Team
    {
        public List<Monster> oMonsters = new List<Monster>();
        private Monster oCurrentMonster;

        public void SetCurrent(ref Monster oMonster)
        {
            oCurrentMonster = oMonster;
        }

        public Monster GetCurrent()
        {
            return oCurrentMonster;
        }

        public bool CheckAllFainted()
        {
            return oMonsters.Where((p) => p != null)
                            .Select((p) => p.bFainted == true)
                                .ToList().Count == oMonsters.Count;
        }

        public Monster GetMonsterAt(int iIndex)
        {
            return oMonsters[iIndex] == null ? null : oMonsters[iIndex];
        }
    }
}
