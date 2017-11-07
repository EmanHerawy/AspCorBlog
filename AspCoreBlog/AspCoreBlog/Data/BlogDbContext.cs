using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreBlog.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AspCoreBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagConfiguration());
            modelBuilder.ApplyConfiguration(new TagsConfiguration());
        }
    }
}
