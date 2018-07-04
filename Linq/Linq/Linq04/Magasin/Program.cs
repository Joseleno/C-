using Magasin.Domaine.Entites;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Magasin
{
    public class Program
    {

        static void Main(string[] args)
        {

            var prod = new Produit().Lister();

            
            // where return un Inumerable
            prod.Where(x => x.Valeur < 10 && x.Quantite > 5).ToList().ForEach(p =>
              {


                   Console.WriteLine("Produit: " + p.Description + " Valeur: " + p.Valeur +
                       " Expiration: " + p.Expiration);

              });


            // JSON FORMAT
            prod = prod.Where(x => x.Valeur < 10 && x.Quantite > 5 && x.Description.ToUpper().Contains("A") ).ToList();

           
           prod.ForEach(p =>
            {

                Console.WriteLine("");
                Console.WriteLine("--------JSON FORMAT-------------");
                Console.WriteLine(JsonConvert.SerializeObject(p));

            });




            Console.ReadKey();

        }


    }
}
