using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.monster;
namespace Monsters.core
{
    class Combat
    {
        public void ApplyMove(ref Monster p, Move m)
        {
            if (m.oEffect.oEffectType != EffectType.NONE && p.oCurrentEffect == EffectType.NONE)
            {
                if (new Random().NextDouble() < m.oEffect.dChance)
                {
                    p.oCurrentEffect = m.oEffect.oEffectType;
                }
            }
            p.iHealth -= m.iDamage;
        }
    }

    class Team
    {
        public List<Monster> oTeam = new List<Monster>();

        public bool CheckAllFainted()
        {
            return oTeam.Where((p) => p != null)
                            .Select((p) => p.bFainted == true)
                                .ToList().Count == oTeam.Count;
        }
    }
}
