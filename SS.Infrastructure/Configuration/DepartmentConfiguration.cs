using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Infrastructure.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(p => p.DID);
            builder.Property(p => p.DName).IsRequired().HasMaxLength(500);

            builder.HasMany(p => p.Students)
                .WithOne(s=>s.Department)
                .HasForeignKey(s=>s.DID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.DepartmentSubjects)
                .WithOne(ds => ds.Department)
                .HasForeignKey(ds=>ds.DID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
