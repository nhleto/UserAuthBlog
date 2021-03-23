using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly UserAuthBlog.Data.ApplicationDbContext _context;

        [BindProperty]
        public Post Post { get; set; }

        [BindProperty]
        public ApplicationUser AppUser { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Attempt at finding user to add the created post to
            //_context.ApplicationUsers.Find(ClaimTypes.NameIdentifier).Posts.Add(Post);

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
