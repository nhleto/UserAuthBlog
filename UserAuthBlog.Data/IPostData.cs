using System.Collections.Generic;

namespace UserAuthBlog.Data
{
    interface IPostData
    {
        public IEnumerable<Post> GetAllPosts(int id);      
    }
}
