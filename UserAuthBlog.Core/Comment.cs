﻿namespace UserAuthBlog.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public ApplicationUser User { get; set; }
        public Post Post { get; set; }
    }
}
