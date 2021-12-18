using Microsoft.EntityFrameworkCore;
using StartUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action = StartUpProject.Models.Action;

namespace StartUpProject.DataLayer
{
    public class StartUpContext:DbContext
    {
        public StartUpContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Action> Actions { get; set; }
        public DbSet<Models.Type> Types { get; set; }

        public DbSet<TypeItem> TypeItems { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Region> Regions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StartUpDb;Trusted_Connection=True;");
    }
}
