using System.Data.Entity;

namespace MVCparcial.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCParcial.Models.Product> Products { get; set; }
    }
}