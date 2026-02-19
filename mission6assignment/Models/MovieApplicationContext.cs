namespace mission6assignment.Models;
using Microsoft.EntityFrameworkCore;

public class MovieApplicationContext : DbContext
{
    public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    public DbSet<Movie> Movies { get; set; }
    
}