using Magasin.Infra.Linq.Repositorie;
using System;


namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new RepoCategorie().AddCategorie(1, "Électroniques");
            //new RepoCategorie().AddCategorie(2, "Boissons");
            //new RepoCategorie().AddCategorie(3, "Fruits");
            new RepoCategorie().AddCategorie(4, "vêtements"); 

            new RepoCategorie().ModifierCategorie(4, "Vêtements");
            new RepoCategorie().SupprimerCategorie(4);

        }
    }
}
