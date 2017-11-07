using AspCoreBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreBlog.Data.Configurations
{
    public class TagsConfiguration : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(e => e.ID).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(30);
            builder.HasMany(e => e.Posts).WithOne(e => e.Tags).HasForeignKey(e => e.TagId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}