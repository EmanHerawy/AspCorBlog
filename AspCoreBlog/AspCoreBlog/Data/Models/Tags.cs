using System.Collections.Generic;

namespace AspCoreBlog.Data.Models
{
    public class Tags
    {
        public Tags()
        {
            this.Posts=new List<PostTag>();
        }
        public int ID { get; set; }
        public string   Name { get; set; }
        public ICollection<PostTag> Posts { get; set; }
    }
}