using System.Data.Entity;

namespace WebApp01.Models
{
    public class WebApp01Context : DbContext
    {
        public WebApp01Context() : base("DefaultConnection")
        {

        }
    }
}