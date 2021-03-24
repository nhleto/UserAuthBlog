using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly IPostData postData;
        
        public IEnumerable<Post> Posts { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }

        public IndexModel(IPostData postData)
        {
            this.postData = postData;
        }
        public IActionResult OnGet()
        {
            Posts = postData.GetAllPosts();
            return Page();
        }
    }
}
