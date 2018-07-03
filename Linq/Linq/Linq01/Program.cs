using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            // sans LINQ 
            Console.WriteLine("Sans LINQ");
            foreach (int n in nombres)
            {
                if (n > 5)
                {
                    Console.WriteLine(n);
                }

            }


            // avec LINQ 
            Console.WriteLine("Avec LINQ");
            foreach (int n in nombres.Where(x => x > 5))
            {
                Console.WriteLine(n);
            }


            Console.ReadKey();
        }
    }
}
