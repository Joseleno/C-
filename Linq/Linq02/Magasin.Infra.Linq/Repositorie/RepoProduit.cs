using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.Infra.Linq.Repositorie
{
    public class RepoProduit
    {
        public void AddProduit(int id, int idCategorie, string nom, decimal valeur)
        {
            Produit prod = new Produit();
            prod.Id = id;
            prod.IdCategorie = idCategorie;
            prod.Description = nom;
            prod.Valeur = valeur;

            MagasinDataContext linq = new MagasinDataContext();
            linq.Produit.InsertOnSubmit(prod);

            linq.SubmitChanges();
        }

        public void ModifierProduit(int id, string nom)
        {
            MagasinDataContext linq = new MagasinDataContext();

            var prod = linq.Produit.First(x => x.Id == id);

            prod.Description = nom;


            linq.SubmitChanges();
        }


        public void SupprimerProduit(int id)
        {
            MagasinDataContext linq = new MagasinDataContext();

            var prod = linq.Produit.First(x => x.Id == id);

            linq.Produit.DeleteOnSubmit(prod);

            linq.SubmitChanges();
        }

        public List<Produit> ListProduits()
        {
            MagasinDataContext linq = new MagasinDataContext();


            //return linq.Produit.ToList();

            //parallel processing
            return linq.Produit.AsParallel().ToList();

        }
            


    }
}

