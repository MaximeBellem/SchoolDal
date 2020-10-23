using Microsoft.EntityFrameworkCore;

namespace SchoolDal
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasIndex(teacher => teacher.Email).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(student => student.Email).IsUnique();
            modelBuilder.Entity<Address>().HasIndex(address => new {address.Street, address.Number, address.Town})
                .IsUnique();

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        
        
    }
}