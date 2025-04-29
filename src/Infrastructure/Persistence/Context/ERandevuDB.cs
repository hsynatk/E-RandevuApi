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
        }
    }
}
