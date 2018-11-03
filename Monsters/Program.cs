using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.core;
namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parser parser = new Parser();


            Console.WriteLine(Renderer.buildHealthBar(50));
            Console.ReadLine();
        }
    }
}
