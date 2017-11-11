using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspCoreBlog.ModelsViews
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            this.Comments=new List<CommentViewModel>();
            this.Tagses=new List<PostTagViewModel>();
        }
        [Key]
        public int ID { get; set; }
        public int BlogId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Post tiltle must be less than 51 characters")]
        [MinLength(5, ErrorMessage = "Post tiltle must be more than 4 characters")]
        public string Title  { get; set; }
        [Required]
        public string Content { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public BlogViewModel Blog { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
        public ICollection<PostTagViewModel> Tagses { get; set; }

    }
}