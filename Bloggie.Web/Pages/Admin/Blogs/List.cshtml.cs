using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bloggie.Web.Pages.Admin.Blogs
{
    public class ListModel(BloggieDbContext bloggieDbContext) : PageModel
    {
        private readonly BloggieDbContext bloggieDbContext = bloggieDbContext;
        public required List<BlogPost> BlogPosts { get; set; }

        public void OnGet()
        {
            BlogPosts = bloggieDbContext.BlogPosts.ToList();
        }
    }
}
 