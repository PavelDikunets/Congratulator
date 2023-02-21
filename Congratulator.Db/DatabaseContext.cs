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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                  new Person { Id = 1, FirstName = "TestUser1", LastName = "testUser1", BirthDate = new DateTime(day: 22, month: 2, year: 1990), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 2, FirstName = "TestUser2", LastName = "testUser2", BirthDate = new DateTime(day: 23, month: 2, year: 1987), SocialStatus = SocialStatus.Friend },
                  new Person { Id = 3, FirstName = "TestUser3", LastName = "testUser3", BirthDate = new DateTime(day: 24, month: 2, year: 1989), SocialStatus = SocialStatus.Familiar },
                  new Person { Id = 4, FirstName = "TestUser4", LastName = "testUser4", BirthDate = new DateTime(day: 25, month: 2, year: 1997), SocialStatus = SocialStatus.Friend },
                  new Person { Id = 5, FirstName = "TestUser5", LastName = "testUser5", BirthDate = new DateTime(day: 26, month: 2, year: 1999), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 6, FirstName = "TestUser6", LastName = "testUser6", BirthDate = new DateTime(day: 27, month: 2, year: 1991), SocialStatus = SocialStatus.Familiar },
                  new Person { Id = 7, FirstName = "TestUser7", LastName = "testUser7", BirthDate = new DateTime(day: 21, month: 2, year: 2000), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 8, FirstName = "TestUser8", LastName = "testUser8", BirthDate = new DateTime(day: 20, month: 2, year: 1985), SocialStatus = SocialStatus.Friend },
                  new Person { Id = 9, FirstName = "TestUser9", LastName = "testUser9", BirthDate = new DateTime(day: 19, month: 2, year: 1995), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 10, FirstName = "TestUser10", LastName = "testUser10", BirthDate = new DateTime(day: 18, month: 2, year: 1986), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 11, FirstName = "TestUser11", LastName = "testUser11", BirthDate = new DateTime(day: 17, month: 2, year: 2001), SocialStatus = SocialStatus.Familiar },
                  new Person { Id = 12, FirstName = "TestUser12", LastName = "testUser12", BirthDate = new DateTime(day: 16, month: 2, year: 1985), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 13, FirstName = "TestUser13", LastName = "testUser13", BirthDate = new DateTime(day: 15, month: 2, year: 2003), SocialStatus = SocialStatus.Friend },
                  new Person { Id = 14, FirstName = "TestUser14", LastName = "testUser14", BirthDate = new DateTime(day: 14, month: 2, year: 1992), SocialStatus = SocialStatus.Familiar },
                  new Person { Id = 15, FirstName = "TestUser15", LastName = "testUser15", BirthDate = new DateTime(day: 13, month: 2, year: 1992), SocialStatus = SocialStatus.Employee },
                  new Person { Id = 16, FirstName = "TestUser16", LastName = "testUser16", BirthDate = new DateTime(day: 12, month: 2, year: 1983), SocialStatus = SocialStatus.Friend },
                  new Person { Id = 17, FirstName = "TestUser17", LastName = "testUser17", BirthDate = new DateTime(day: 11, month: 2, year: 1997), SocialStatus = SocialStatus.Employee }
                  );
        }
    }
}
