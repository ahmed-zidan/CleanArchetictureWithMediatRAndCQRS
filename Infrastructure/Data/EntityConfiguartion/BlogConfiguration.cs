using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityConfiguartion
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData(
                new Blog() { Author = "AHMED", Description = "DESCRIPTION1", Id = 1, Name = "BLOG1" },
                new Blog() { Author = "Ali", Description = "DESCRIPTION2", Id = 2, Name = "BLOG2" },
                new Blog() { Author = "Khaled", Description = "DESCRIPTION3", Id = 3, Name = "BLOG3" }
                );
        }
    }
}
