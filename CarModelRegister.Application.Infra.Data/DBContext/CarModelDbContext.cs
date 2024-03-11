using CarModelRegister.Application.Domain.Aggregates;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace CarModelRegister.Application.Infra.Data.DBContext
{
    public class CarModelDbContext : DbContext
    {
        public static string Schema => "carzen";

        public DbSet<Car> Car { get; set; }

        public DbSet<Financial> Financial { get; set; }

        public CarModelDbContext(DbContextOptions<CarModelDbContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.Entity<Car>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<Financial>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Ignore<Notification>();


            base.OnModelCreating(modelBuilder);
        }

        public class IntegrationContextFactory : IDesignTimeDbContextFactory<CarModelDbContext>
        {
            public CarModelDbContext CreateDbContext(string[] args)
            {
                var optionBuilder = new DbContextOptionsBuilder<CarModelDbContext>();

                optionBuilder.UseSqlServer("Data Source=localhost;Database=CarModelDB;Trusted_Connection=True;Trust Server Certificate = true;") ;
                
                return new CarModelDbContext(optionBuilder.Options);
            }
        }

    }
}
