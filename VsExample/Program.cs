using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace VsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureGUI();
            for (int i = 0; i < 5; i++)
            {
                
            }

            Console.ReadLine();

        }

        private static void ConfigureGUI()
        {
            Console.Title = "asdasd";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to my Rock App");
            Console.WriteLine("asdasdasdasdasdasdasdasdasdasdasd");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
