using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.core
{
    class Monsters
    {
        public String sName { get; set; }
        public int iHealth { get; set; }
        public Move[] aMoves = new Move[4];
        public EffectType oCurrentEffect { get; set; }
        public bool bFainted;
    }
}
