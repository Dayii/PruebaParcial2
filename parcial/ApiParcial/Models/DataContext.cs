using System.Data.Entity;

namespace ApiParcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<ApiParcial.Models.Product> Products { get; set; }
    }
}