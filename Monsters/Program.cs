using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.core;
using Monsters.mechanics;
using Monsters.monster;

namespace Monsters
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Combat oCombat = new Combat();
            //Renderer.WriteOut("Current Monster is " + oCombat.player1.GetCurrent().sName);
            //Renderer.RenderAttackMenu(oCombat.player1.oMonsters[0]);
            //Renderer.PrintTeam(oCombat.player1);
            //Console.ReadLine();
            while(true)
            {
                Renderer.RenderBattleMenu();
                switch(Parser.GetMenuChoice("", Enums.InputType.MENU))
                {
                    case "attack":
                        Renderer.WriteOut("\n");
                        Renderer.RenderAttackMenu(oCombat.player1.GetCurrent());
                        Move oSelectedMove;

                        do
                        {
                            oSelectedMove = Parser.GetMove(oCombat.player1.GetCurrent().oMoves);
                            if (oSelectedMove == null) Renderer.WriteOut("Move not recognised");
                        } while (oSelectedMove == null);


                        Monster oEnemyCurrent = oCombat.player2.GetCurrent();
                        oCombat.ApplyMove(ref oEnemyCurrent, oSelectedMove);


                        Renderer.WriteOut("\n Dealt " + oSelectedMove.iDamage + " damage to enemy's " + oEnemyCurrent.sName);
                        break;
                }


                Console.Read();
            }
        }
    }
}
