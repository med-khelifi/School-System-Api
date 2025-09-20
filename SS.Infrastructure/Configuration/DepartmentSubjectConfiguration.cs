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
    internal class DepartmentSubjectConfiguration : IEntityTypeConfiguration<DepartmetSubject>
    {
        public void Configure(EntityTypeBuilder<DepartmetSubject> builder)
        {
            builder.HasKey(p => p.DeptSubID);
            builder.Property(p => p.SubID).IsRequired();
            builder.Property(p => p.DID).IsRequired();

            builder.HasOne(ds => ds.Department)
                .WithMany(d => d.DepartmentSubjects)
                .HasForeignKey(ds => ds.DID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ds => ds.Subject)
                .WithMany(s => s.DepartmetsSubjects)
                .HasForeignKey(ds => ds.SubID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
