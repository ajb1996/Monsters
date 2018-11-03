using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.core
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
            if(oMoves.Count <= 4)
            {
                oMoves.Add(m);
            }
        }
    }
}
