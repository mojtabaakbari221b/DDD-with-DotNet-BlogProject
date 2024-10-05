using Blog.Blog.Application.DTOs;


namespace Blog.Blog.Application.Services
{
    public interface BlogService
    {
        Task DeleteAsync(int id);
        Task<BlogDto> AddAsync();
    }
}
