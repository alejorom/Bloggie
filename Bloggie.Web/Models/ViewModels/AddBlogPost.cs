namespace Bloggie.Web.Models.ViewModels
{
    public class AddBlogPost
    {
        public required string Heading { get; set; }
        public required string PageTitle { get; set; }
        public required string Content { get; set; }
        public required string ShortDescription { get; set; }
        public required string FeatureImageUrl { get; set; }
        public required string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string Author { get; set; }
        public bool Visible { get; set; }
    }
}
