using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence.Context
{
    public class ERandevuDB : DbContext
    {
        public ERandevuDB()
        { }

        public ERandevuDB(DbContextOptions<ERandevuDB> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // fallback için doğrudan bağlantı dizesi
                optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=ERandevuDB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        public DbSet<Clinic> Clinics { get; set; }
    }
}
