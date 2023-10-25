using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldData.entities;

namespace WorldData.Repositories
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }


        public DbSet<Country> MyProperty { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> cities { get; set; }

    }
}
