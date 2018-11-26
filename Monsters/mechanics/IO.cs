using Monsters.core;
using Monsters.monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Monsters.mechanics
{
    internal static class Parser
    {
        public static string GetInput(string sPrompt, Enums.InputType i)
        {
            if (sPrompt != "")
            {
                Renderer.WriteOut(sPrompt);
            }
            return Console.ReadLine().ToLower();
        }

        public static string GetMenuChoice(string sPrompt, Enums.InputType i)
        {
            string sInput = GetInput(sPrompt, i);
            switch (i)
            {
                case Enums.InputType.MENU:
                    if (sInput.Equals("monsters") || sInput.Equals("items") || sInput.Equals("attack"))
                    {
                        return sInput;
                    }
                    break;
                case Enums.InputType.ATTACK:
                    return sInput;
            }
            Console.WriteLine("Command not recognised");
            return GetMenuChoice(sPrompt, i);
        }

        public static Move GetMove(List<Move> oMoves)
        {
            string sMoveInput = Console.ReadLine().ToLower();
            Move matchedMove = oMoves.Where((m) => m.sName.ToLower() == sMoveInput).FirstOrDefault();
            return matchedMove != null ? matchedMove : null;
        }
    }

    public static class Renderer
    {
        public static void PrintTeam(Team t)
        {
            foreach (Monster oMon in t.oMonsters)
            {
                StringBuilder line = new StringBuilder();
                line.Append(oMon.sName);
                line.Append("       ");
                line.Append(BuildHealthBar(oMon.iHealth));
                line.Append("       ");
                line.Append(oMon.oCurrentEffect.ToString());
                line.Append("       ");
                line.Append(oMon.bFainted ? "Fainted" : "");
                Console.WriteLine(line.ToString());
            }
        }
        public static string BuildHealthBar(int health)
        {
            StringBuilder healthBar = new StringBuilder();
            for (int i = 0; i < health / 2; i++)
            {
                healthBar.Append("|");
            }
            for (int i = 0; i < (100 - health) / 2; i++)
            {
                healthBar.Append(".");
            }
            return healthBar.ToString();
        }
        public static void WriteOut(string s)
        {
            Console.WriteLine(s);
        }
        public static void RenderBattleMenu()
        {
            Console.WriteLine("Attack         Monsters");
            Console.WriteLine("Items          Run");
        }
        public static void RenderAttackMenu(Monster oMonsterToRender)
        {
            Console.WriteLine("Select Move:");
            foreach (Move oMoveToRender in oMonsterToRender.oMoves)
            {
                Console.Write(oMoveToRender.sName);
                int moveIndex = oMonsterToRender.oMoves.IndexOf(oMoveToRender);
                if (moveIndex % 2 != 0)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(NicelySpace(oMoveToRender.sName.Length));
                }
            }
        }
        private static string NicelySpace(int length)
        {
            StringBuilder sb = new StringBuilder();

            for (int spaces = 0; spaces < (20 - length); spaces++)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }

}
