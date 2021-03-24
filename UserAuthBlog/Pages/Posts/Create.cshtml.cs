using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Post Post { get; set; }

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
            var Taggs = new List<Tag>();
            var Tag = new Tag() { Name = "Seed Tag", PostId = Post.Id };
            Taggs.Add(Tag);
            //Tags.Add(new)
            var post = new Post { Title = "Seed", Body = "Seed", Tags = Taggs  ,ApplicationUserId = "463a66ad-afa9-4e45-bf75-9356dda65606" };
            _context.Add(post);
            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();
            return RedirectToPage("./List");
        }
    }
}
