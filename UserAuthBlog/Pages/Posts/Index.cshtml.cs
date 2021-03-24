using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IPostData postData;

        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }

        public IndexModel(ApplicationDbContext _context, IPostData postData)
        {
            this._context = _context;
            this.postData = postData;
        }
        public IActionResult OnGet()
        {
            Posts = postData.GetAllPosts();
            return Page();
        }
    }
}
