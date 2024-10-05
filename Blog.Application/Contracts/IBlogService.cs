using Blog.Blog.Application.DTOs;

namespace Blog.Blog.Application.Contracts
{
    public interface IBlogService
    {
        Task<OperationResult> Add(CreateBlogDto dto);
        Task Delete(int id);
    }
}
