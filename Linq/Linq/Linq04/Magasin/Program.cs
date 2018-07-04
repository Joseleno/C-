using Magasin.Domaine.Entites;
using System;
using System.Linq;

namespace Magasin
{
    public class Program
    {

        static void Main(string[] args)
        {

            var prod = new Produit();
            
            // where return un Inumerable
            prod.Lister().Where(x => x.Valeur < 10 && x.Quantite > 5).ToList().ForEach(p =>
              {
                  Console.WriteLine("Produit: " + p.Description + " Valeur: " + p.Valeur +
                      " Expiration: " + p.Expiration);
              });


            Console.ReadKey();

        }


    }
}
