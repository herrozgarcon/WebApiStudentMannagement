using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppDbContext:DbContext
{
    
    public DbSet<Students> Students { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=webApi;User Id=sa;Password=Hrithik21$;TrustServerCertificate=True;");
        }
    }
    
}