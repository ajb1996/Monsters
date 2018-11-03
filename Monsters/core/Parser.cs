using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.core
{
    static class Parser
    {
        public static String getInput(String sPrompt, InputType i)
        {
            String sInput;
            Console.WriteLine(sPrompt);
            sInput = Console.ReadLine().ToLower();
            switch (i)
            {
                case InputType.MENU:
                    if (sInput.Equals("Monsters") || sInput.Equals("items") || sInput.Equals("attack"))
                    {
                        return sInput;
                    }
                    break;
            }
            Console.WriteLine("Command not recognised");
            return getInput(sPrompt, i);
        }
    }

    static class Renderer
    {
        public static void PrintTeam(Team t)
        {
            foreach (Monsters oMon in t.oTeam)
            {


            }
        }

        private static String buildHealthBar(Monsters oMon)
        {
            StringBuilder healthBar = new StringBuilder();
            for (int i = 0; i < oMon.iHealth; i++)
            {
                healthBar.Append("|");
            }
            for (int i = 0; i < (100 - oMon.iHealth); i++)
            {
                healthBar.Append(".");
            }
            return healthBar.ToString();
        }

        public static String buildHealthBar(int health)
        {
            StringBuilder healthBar = new StringBuilder();
            for (int i = 0; i < health/2; i++)
            {
                healthBar.Append("|");
            }
            for (int i = 0; i < (100 - health)/2; i++)
            {
                healthBar.Append(".");
            }
            return healthBar.ToString();
        }
    }

    enum InputType
    {
        MENU, ATTACK, ITEM, TEAM
    }
}
