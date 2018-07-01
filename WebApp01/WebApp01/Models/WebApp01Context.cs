using System.Data.Entity;

namespace WebApp01.Models
{
    public class WebApp01Context : DbContext
    {
        public WebApp01Context() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApp01.Models.Entities.Departament> Departaments { get; set; }
    }
}