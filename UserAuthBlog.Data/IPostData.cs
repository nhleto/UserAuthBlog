using System.Collections.Generic;

namespace UserAuthBlog.Data
{
    public interface IPostData
    {
        public IEnumerable<Post> GetAllPosts();
        public Post DeletePost(int Id);
        public int Commit();
        public Post GetPostById(int Id);
    }
}
