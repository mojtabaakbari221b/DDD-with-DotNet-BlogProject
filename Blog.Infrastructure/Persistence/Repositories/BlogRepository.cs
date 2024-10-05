using Blog.Blog.Domain.Contracs;
using Blog.Blog.Infrastructure.Persistence.Models;


namespace Blog.Blog.Infrastructure.Persistence.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _db;

        public BlogRepository(BlogDbContext db)
        {
            _db = db;
        }

        public async void Add(string Name, string Description, string? Author)
        {
            var blogData = new BlogData()
            {
                Name = Name,
                Description = Description,
                Author = Author,
            };
            _db.Blogs.Add(blogData);
        }

        public void Delete(int id)
        {
            var blogData = _db.Blogs.Find(id);
            if (blogData != null) {
                _db.Blogs.Remove(blogData);
            }
        }
    }
}
