namespace MotoApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using MotoApp.Entites;

    public class MotoAppDbContext : DbContext            //z usinga Microsoft
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<BusinessPartner> BusinessPartner => Set<BusinessPartner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}