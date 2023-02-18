using Congratulator.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Congratulator.Db
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
