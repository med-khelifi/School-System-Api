using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SS.Core.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SS.Infrastructure.Configuration
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(p => p.SubID);
            builder.Property(p => p.SubjectName)
                .HasMaxLength(500);
            builder.Property(p => p.Period)
                .IsRequired();
            builder.HasMany(s => s.StudentsSubjects)
                .WithOne(ss => ss.Subject)
                .HasForeignKey(ss=> ss.SubID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(s => s.DepartmetsSubjects)
                .WithOne(ds => ds.Subject)
                .HasForeignKey(ds=> ds.SubID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
