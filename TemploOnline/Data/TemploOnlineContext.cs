using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Data
{
  public class TemploOnlineContext : IdentityDbContext<User>
  {
    public DbSet<Category> Categories { get; set; }

    public DbSet<Person> People { get; set; }

    public DbSet<Textbook> TextBooks { get; set; }

    public DbSet<Lesson> Lessons { get; set; }

    public TemploOnlineContext(DbContextOptions<TemploOnlineContext> options)
      :base(options)
    {
        
    }
  }
}