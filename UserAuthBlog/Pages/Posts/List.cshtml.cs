using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class ListModel : PageModel
    {
        private readonly UserAuthBlog.Data.ApplicationDbContext _context;
        public IList<Post> Post { get; set; }

        public ListModel(UserAuthBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync()
        {
            Post = await _context.Posts
                .Include(p => p.User).ToListAsync();
        }
    }
}
