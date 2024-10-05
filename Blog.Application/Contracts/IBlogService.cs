using Blog.Blog.Application.DTOs;

namespace Blog.Blog.Application.Contracts
{
    public interface IBlogService
    {
        Task<BlogDto> AddAsync(BlogDto blogDto);
        Task DeleteAsync(int id);
    }
}
