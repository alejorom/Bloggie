namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required Guid BlogPostId { get; set; }
    }
}
