using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public Post Post { get; set; }

        public EditModel(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult OnGet(int postId)
        {
            Post = context.Posts.Find(postId);
            return Page();
        }
    }
}
