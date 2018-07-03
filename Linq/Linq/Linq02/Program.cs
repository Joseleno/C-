using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            var resultat = from n in nombres
                           where n > 5
                           orderby n descending
                           select n;

            foreach (int n in resultat)
            {
                Console.WriteLine(n);
            }


            Console.ReadKey();
        }
    }
}