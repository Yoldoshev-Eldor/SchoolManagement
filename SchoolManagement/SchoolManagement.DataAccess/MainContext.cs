using Microsoft.EntityFrameworkCore;
using SchoolManagement.DataAccess.Entities;

namespace SchoolManagement.DataAccess;

public class MainContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes { get; set; }

    public MainContext(DbContextOptions<MainContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new StudentConfiguration());
        //modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        //modelBuilder.ApplyConfiguration(new ClassConfiguration());
    }
}
