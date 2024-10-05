using Blog.Blog.Application.Contracts;
using Blog.Blog.Application.DTOs;
using Blog.Blog.Domain.Contracs;

namespace Blog.Blog.Application.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public Task<OperationResult> Add(CreateBlogDto dto)
        {
            _blogRepository.Add(
                dto.Name,
                dto.Description,
                dto.Author
            );
            return new OperationResult { Message = "blog saved successfully.", Success = true };
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
