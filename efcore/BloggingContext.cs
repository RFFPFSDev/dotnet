using Microsoft.EntityFrameworkCore;

namespace efcore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Server=localhost;Database=localdb;Trusted_Connection=True; TrustServerCertificate=True;");
}
