using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCoreBlog.ModelsViews
{
    public class TagsViewModel
    {
        public TagsViewModel()
        {
            this.Posts=new List<PostTagViewModel>();
        }
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Post tiltle must be less than 31 characters")]
        public string   Name { get; set; }
        public ICollection<PostTagViewModel> Posts { get; set; }
    }
}