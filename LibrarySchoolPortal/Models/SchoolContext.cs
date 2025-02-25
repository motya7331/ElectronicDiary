using Microsoft.EntityFrameworkCore;

namespace LibrarySchoolPortal
{
    public class SchoolContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }
    }
}