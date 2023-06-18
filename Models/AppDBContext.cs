using System;
using Microsoft.EntityFrameworkCore;
namespace Models
{

    public class AppDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Individual> individuals { get; set; }
        public DbSet<Comprate> comprates { get; set; }
        
        
        public DbSet<Section> Sections { get; set; }
        
        public DbSet<Particpant> particpants { get; set; }

        public DbSet<Schedule>? Schedules { get; set; }


        public DbSet<Enrollment>? Enrollments { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conf = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connstring = conf.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(connstring);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // get all configuration classes 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }

    }
}