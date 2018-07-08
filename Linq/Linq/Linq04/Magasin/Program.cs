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
            var prod2 = new Produit().Lister();
            var prod3 = new Produit().Lister();

            // where return un Inumerable
            prod.Where(x => x.Valeur < 10 && x.Quantite > 5).ToList().ForEach(p =>
              {
                  Console.WriteLine("Produit: " + p.Description + " Valeur: " + p.Valeur +
                      " Expiration: " + p.Expiration);
              });


            // JSON FORMAT
            prod = prod.Where(x => x.Valeur < 10 && x.Quantite > 5 && x.Description.ToUpper().Contains("A")).ToList();

            prod.ForEach(p =>
             {
                 Console.WriteLine("");
                 Console.WriteLine("--------JSON FORMAT-------------");
                 Console.WriteLine(JsonConvert.SerializeObject(p));

             });
            Console.WriteLine("");
            Console.WriteLine("--------Exemple 3-------------");
            // Un autre exemple
            var descritions = prod2
                .Where(p => p.Description.ToUpper().StartsWith("P"))
                .Select(p => p.Description)
                .ToList();

            descritions.ForEach(X =>
            {
                Console.WriteLine(X);
            });



            Console.WriteLine("");
            Console.WriteLine("--------Exemple 4-------------");
            // exemple 4 generic objet
            var objets = prod2
                .Where(p => p.Description.ToUpper().StartsWith("P"))
                .Select(p => new { p.Description, p.Valeur, p.Expiration })
                .ToList();

            objets.ForEach(X =>
            {
                Console.WriteLine(X);
            });



            Console.WriteLine("");
            Console.WriteLine("--------Exemple 5-------------");
            // exemple 5 Typed Objet
            var resultSelected = prod2
                .Where(a => a.Description.ToUpper().StartsWith("P"))
                .Select(a => new ProduitSelected { Description = a.Description, Valeur = a.Valeur, Expiration = a.Expiration })
                .ToList();

            if (resultSelected.Any())
            {
                resultSelected.ForEach(X =>
                {
                    Console.WriteLine(JsonConvert.SerializeObject(X));
                });
            }


            Console.WriteLine("");
            Console.WriteLine("--------Exemple 6 - les fonctions d'agrégation-------------");
            // les fonctions d'agrégation
            if (prod3.Any())
            {
                var exempleGroup = from p in prod3
                                   group p by p.Type into groupT
                                   select new
                                   {
                                       Description = groupT.Key,
                                       PrixMoinCher = groupT.Min(x => x.Valeur),
                                       PrixPlusCher = groupT.Max(x => x.Valeur)
                                   };

                Console.WriteLine(JsonConvert.SerializeObject(exempleGroup));


            }


            Console.ReadKey();


        }


    }
}
