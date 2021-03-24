using System.Collections.Generic;

namespace UserAuthBlog.Data
{
    public interface IPostData
    {
        public IEnumerable<Post> GetAllPosts();
    }
}
