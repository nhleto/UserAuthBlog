using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts

{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IPostData postData;

        public IList<Post> Post { get; set; }

        public ListModel(ApplicationDbContext context, IPostData postData)
        {
            _context = context;
            this.postData = postData;
        }

        public IActionResult OnGet()
        {
            Post = (IList<Post>)postData.GetAllPosts();
            return Page();
        }
    }
}
