using Microsoft.EntityFrameworkCore;

namespace LibrarySchoolPortal
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TestSchedule> TestSchedules { get; set; }
        public DbSet<CurrentGrade> CurrentGrades { get; set; }
        public DbSet<TestGrade> TestGrades { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\chech\\source\\repos\\LibrarySchoolPortal\\LibrarySchoolPortal\\school.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Classes)
                .WithMany(c => c.Teachers);
        }
    }
}