using Magasin.Infra.Linq.Repositorie;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new RepoCategorie().AddCategorie(1, "Électroniques");
            //new RepoCategorie().AddCategorie(2, "Boissons");
            //new RepoCategorie().AddCategorie(3, "Fruits");
            //new RepoCategorie().AddCategorie(4, "vêtements"); 
            //new RepoCategorie().ModifierCategorie(4, "Vêtements");
            //new RepoCategorie().SupprimerCategorie(4);
            //new RepoProduit().AddProduit(1, 1, "Ordinateur ACER", 850);
            //new RepoProduit().AddProduit(2, 1, "Ordinateur SONNY", 1050);
            //new RepoProduit().AddProduit(3, 1, "Ordinateur DELL", 950);
            //new RepoProduit().AddProduit(4, 1, "Ordinateur SAMSUNG", 1150);
            //new RepoProduit().AddProduit(5, 1, "Ordinateur APPLE", 1850);
            //new RepoProduit().AddProduit(6, 2, "Biere STELLA", 5);
            //new RepoProduit().AddProduit(7, 2, "Biere Heineken", 6);
            //new RepoProduit().AddProduit(8, 3, "Pomme", 3);
            //new RepoProduit().AddProduit(9, 3, "Raisin", 4);
            //new RepoProduit().AddProduit(10, 4, "Pantalon", 7);
            //new RepoProduit().AddProduit(11, 4, "Robe", 8);

            var produits = new RepoProduit().ListProduits();

            produits.ForEach(x => Console.WriteLine("Produit: " + x.Description + "  Categorie: " + x.IdCategorie + "  Prix: " + x.Valeur));

            Console.ReadKey();


        }

    }
}