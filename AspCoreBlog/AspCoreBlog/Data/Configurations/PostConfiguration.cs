using AspCoreBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreBlog.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(e => e.ID).ValueGeneratedOnAdd();
            builder.Property(e => e.Title).HasMaxLength(50);
            builder.HasMany(e => e.Tagses).WithOne(e => e.Post).HasForeignKey(e => e.PostId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Comments).WithOne(e => e.Post).HasForeignKey(e => e.PostId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Blog).WithMany(e => e.Post).HasForeignKey(e => e.BlogId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}