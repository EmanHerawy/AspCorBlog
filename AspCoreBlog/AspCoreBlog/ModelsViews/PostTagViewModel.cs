namespace AspCoreBlog.ModelsViews
{
    public class PostTagViewModel
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public PostViewModel Post { get; set; }
        public TagsViewModel Tags { get; set; }
    }
}