namespace ON4X.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<ON4X.Common.Models.Product> Products { get; set; }
    }
}