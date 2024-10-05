using Blog.Blog.Domain.Entities;

namespace Blog.Blog.Domain.Contracs
{
    public interface IBlogRepository
    {
        void Add(string Name,  string Description, string? Author);
        void Delete(int id);
    }
}
