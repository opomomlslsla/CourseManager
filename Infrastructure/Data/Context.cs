using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Disciplline> Discipllines { get; set;}
    public DbSet<Group> Groups { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    public DbSet<Student> Students { get; set; }
}
