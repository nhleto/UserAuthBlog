using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace UserAuthBlog.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
