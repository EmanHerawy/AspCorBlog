using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCoreBlog.ModelsViews
{
    public class BlogViewModel
    {
        public BlogViewModel()
        {
            this.Post = new List<PostViewModel>();
        }
        [Required]
        public int ID { get; set; }
        [MaxLength(20,ErrorMessage = "Blog name must be less than 21 characters")]

        [MinLength(3, ErrorMessage = "Blog name must be more than 4 characters")]
        public string BlogTitle { get; set; }
        public string BlogDesc { get; set; }
        public ICollection<PostViewModel> Post { get; set; }
    }
}
