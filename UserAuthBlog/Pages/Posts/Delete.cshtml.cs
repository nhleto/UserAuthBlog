using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserAuthBlog.Data;

namespace UserAuthBlog.Pages.Posts
{
    public class DeleteModel : PageModel
    {
        private readonly IPostData postData;

        [BindProperty(SupportsGet = true)]
        public Post Post { get; set; }
        
        public DeleteModel(IPostData postData)
        {
            this.postData = postData;
        }
        public IActionResult OnGet(int postId)
        {
            Post = postData.GetPostById(postId);
            if (Post == null)
            {
                return RedirectToPage("../NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(int posId)
        {
            return Page();
        }
    }
}
