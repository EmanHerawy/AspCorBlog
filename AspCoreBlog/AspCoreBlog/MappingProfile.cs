using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreBlog.Data.Models;
using AspCoreBlog.ModelsViews;
using AutoMapper;

namespace AspCoreBlog
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, BlogViewModel>().ReverseMap();
            CreateMap<PostTag, PostViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<Comment, CommentViewModel>().ReverseMap();
            CreateMap<Tags, TagsViewModel>().ReverseMap();
        }
    }
}
