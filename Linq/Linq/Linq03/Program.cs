using System;
using System.Linq;

namespace Linq03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banane", "cerise", "framboise", "citron", "pomme", "mangue", "raisin" };

            var listFruit = fruits.Where(x => x.Contains("o") || x.Contains("e"));

            foreach (string fruit in listFruit)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();
        }
    }
}
