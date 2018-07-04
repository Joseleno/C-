using System;
using System.Collections.Generic;

namespace Magasin.Domaine.Entites
{
    public class Produit
    {
        
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int Quantite { get; set; }

        public DateTime Expiration { get; set; }

        public decimal Valeur { get; set; }

        public List<Produit> _produits;

        public Produit()
        {
            _produits = new List<Produit>();

        }

        


        



        public List<Produit> Lister()
        {

            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Réfrigérant", Quantite = 10, Expiration = DateTime.Now.AddDays(30), Valeur = 5 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Pomme", Quantite = 5, Expiration = DateTime.Now.AddDays(10), Valeur = 2 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Bière", Quantite = 20, Expiration = DateTime.Now.AddDays(60), Valeur = 10 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Pain", Quantite = 3, Expiration = DateTime.Now.AddDays(5), Valeur = 3 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Nutella", Quantite = 1, Expiration = DateTime.Now.AddDays(15), Valeur = 7 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Fraise", Quantite = 10, Expiration = DateTime.Now.AddDays(5), Valeur = 5 });
            _produits.Add(new Produit() { Id = Guid.NewGuid(), Description = "Myrtille", Quantite = 10, Expiration = DateTime.Now.AddDays(7), Valeur = 15 });

            return _produits;
        }

    }
}
