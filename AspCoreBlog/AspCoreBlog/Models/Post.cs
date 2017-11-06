using System;
using System.Collections.Generic;

namespace AspCoreBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments=new List<Comment>();
            this.Tagses=new List<PostTag>();
        }
        public int ID { get; set; }
        public int BlogId { get; set; }
        public string Title  { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Blog Blog { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<PostTag> Tagses { get; set; }

    }
}