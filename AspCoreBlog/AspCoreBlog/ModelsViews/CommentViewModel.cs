using System;
using System.ComponentModel.DataAnnotations;

namespace AspCoreBlog.ModelsViews
{
    public class CommentViewModel
    {
        [Key]
        public int ID    { get; set; }
        public int PostId { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Comment must be less than 301 characters")]
        [MinLength(3, ErrorMessage = "Comment must be more than 3 characters")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public PostViewModel Post { get; set; }

    }
}