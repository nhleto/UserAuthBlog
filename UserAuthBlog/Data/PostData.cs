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

        public PostData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return db.Posts;
        }
    }
}
