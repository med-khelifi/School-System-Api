using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Infrastructure.Configuration
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(property => property.StudSubID);
            builder.Property(p=>p.StudID).IsRequired();
            builder.Property(p=>p.SubID).IsRequired();

            builder.HasOne(ss => ss.Subject)
                .WithMany(s=>s.StudentsSubjects)
                .HasForeignKey(ss => ss.SubID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.StudentsSubjects)
                .HasForeignKey(ss => ss.StudID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
