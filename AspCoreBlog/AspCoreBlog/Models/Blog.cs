using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreBlog.Models
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
