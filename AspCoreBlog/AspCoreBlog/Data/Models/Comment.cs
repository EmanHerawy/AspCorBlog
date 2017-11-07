using System;

namespace AspCoreBlog.Data.Models
{
    public class Comment
    {
        public int ID    { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Post Post { get; set; }

    }
}