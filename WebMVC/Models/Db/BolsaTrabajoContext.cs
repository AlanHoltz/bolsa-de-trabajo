using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace BolsaTrabajo.Models.Db
{
    public class BolsaTrabajoContext: DbContext
    {
        public BolsaTrabajoContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<JobProfile> JobProfiles { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
    }
}
