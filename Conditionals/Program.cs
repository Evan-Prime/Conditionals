using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals: ");
            Console.WriteLine("--------------");
            Console.WriteLine();

            int score;
            string gamertag;

            score = 0;
            gamertag = "Non-Gamer";
            gamertag = "EvanSeven2003";
            if (gamertag == "EvanSeven2003")
            {
                score = 1000000; // Cheating >;)
            }
            Console.WriteLine("Score: " + score);

            Console.ReadKey(true);
        }
    }
}
