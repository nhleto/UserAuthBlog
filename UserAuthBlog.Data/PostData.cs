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

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Post DeletePost(int Id)
        {
            var post = db.Posts.Find(Id);
            if (post != null)
            {
                db.Posts.Remove(post);
            }
            return post;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            //"Include" is part of EF Core. Just like in RoR. Use "Include" to reduce N + 1 queries
            return Post = db.Posts
                .Include(p => p.User)
                .Include(p => p.Comments)
                .Include(p => p.Tags)
                .AsSplitQuery()
                //I was sent to look at docs from the CLI and after "splitting" this query, error message went away
                .ToList();
        }

        public Post GetPostById(int Id)
        {
            return db.Posts.FirstOrDefault(p => p.Id == Id);
        }
    }
}
