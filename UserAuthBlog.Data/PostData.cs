using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace UserAuthBlog.Data
{
    public class PostData : IPostData
    {

        private readonly ApplicationDbContext db;

        private List<Post> Post;

        public PostData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            //"Include" is part of EF Core. Just like in RoR. Use "Include" to reduce N + 1 queries
            return Post = db.Posts
                .Include(p => p.User)
                .Include(p => p.Comments)
                .Include(p => p.Tags)
                .AsSplitQuery()
                .ToList();
        }
    }
}
