using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.Infra.Linq.Repositorie
{
    public class RepoCategorie
    {
        public void AddCategorie(int id, string nom)
        {
            Categorie cat = new Categorie();
            cat.Id = id;
            cat.Description = nom;

            MagasinDataContext linq = new MagasinDataContext();
            linq.Categorie.InsertOnSubmit(cat);

            linq.SubmitChanges();
        }

        public void ModifierCategorie(int id, string nom)
        {
            MagasinDataContext linq = new MagasinDataContext();

            var cat = linq.Categorie.First(x => x.Id == id);

            cat.Description = nom;

            
            linq.SubmitChanges();
        }


        public void SupprimerCategorie(int id)
        {
            MagasinDataContext linq = new MagasinDataContext();

            var cat = linq.Categorie.First(x => x.Id == id);

            linq.Categorie.DeleteOnSubmit(cat);

            linq.SubmitChanges();
        }
        
    }
}
