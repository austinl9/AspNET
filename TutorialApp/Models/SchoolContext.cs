using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //main class that cooridnates Entity framework functionality is the database context class
        //create this class by deriving from entity.dbcontext

        //This code creats a dbset property for each entity set
        // an entity set typically means a database table, and an entity correstponds to a row in the table

        //EF context is not thread safe, so don't try to do multiple operations in parallel.
        // when you call any async EF method always use the await keyword
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //DF creates tables that have names the same as dbset property names
        //property names for collections are typically plural
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}