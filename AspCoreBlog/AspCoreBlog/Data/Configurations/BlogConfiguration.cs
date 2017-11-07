using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreBlog.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreBlog.Data.Configurations
{
    public class BlogConfiguration:IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(e => e.ID);
            builder.Property(e => e.ID).ValueGeneratedOnAdd();
            builder.Property(e => e.BlogTitle).HasMaxLength(20);
        }
    }
}
