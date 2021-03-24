using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Include is part of EF Core. Just like in RoR. Use Include to reduce N + 1 queries
            return Post = db.Posts
                .Include(p => p.User)
                .ToList();
        }
    }
}
