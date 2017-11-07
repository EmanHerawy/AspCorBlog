using System.Collections.Generic;

namespace AspCoreBlog.Data.Models
{
    public class Blog
    {
        public Blog()
        {
            this.Post = new List<Post>();
        }
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDesc { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
