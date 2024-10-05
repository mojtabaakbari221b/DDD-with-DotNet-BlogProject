namespace Blog.Blog.Application.DTOs
{
    public record CreateBlogDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }

    public record BlogDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
