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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(p => p.StudID);
            builder.Property(p=>p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p=>p.Address).HasMaxLength(500).IsRequired();
            builder.Property(p=>p.Phone).HasMaxLength(500).IsRequired();

            builder.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s=>s.DID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
