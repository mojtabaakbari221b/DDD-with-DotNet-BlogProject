using Microsoft.EntityFrameworkCore;
using Blog.Blog.Infrastructure.Persistence.Models;


namespace Blog.Blog.Infrastructure.Persistence
{
    public class BlogDbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options): base(options)
        {
        }

        public DbSet<BlogData> Blogs { get; set; }
    }
}
