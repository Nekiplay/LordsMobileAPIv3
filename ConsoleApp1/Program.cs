using LordsMobileAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            LordsMobile lordsMobile = new LordsMobile();
            sw.Stop();
            Console.WriteLine("Lords Mobile API initialized in {0}ms", sw.ElapsedMilliseconds);
            Console.WriteLine();
            Console.WriteLine("Stamina: " + lordsMobile.user.Stamina);
            Console.WriteLine();
            Console.WriteLine("Food: " + Math.Round(lordsMobile.resource.Food, 2));
            Console.WriteLine("Stone: " + Math.Round(lordsMobile.resource.Stone, 2));
            Console.WriteLine("Wood: " + Math.Round(lordsMobile.resource.Wood, 2));
            Console.WriteLine("Ore: " + Math.Round(lordsMobile.resource.Ore, 2));
            Console.WriteLine("Gold: " + Math.Round(lordsMobile.resource.Gold, 2));
            Console.ReadLine();
        }
    }
}
