namespace ON4X.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<ON4X.Common.Models.Product> Products { get; set; }
    }
}
