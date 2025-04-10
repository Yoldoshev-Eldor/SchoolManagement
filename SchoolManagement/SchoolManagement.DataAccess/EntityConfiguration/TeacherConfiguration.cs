using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.EntityConfiguration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teachers");

        builder.HasKey(t => t.TeacherID);

        builder.Property(t => t.FirstName).IsRequired(true)
            .HasMaxLength(50);

        builder.Property(t => t.LastName).IsRequired(true).
            HasMaxLength(50);

        builder.Property(t => t.Age).IsRequired(true);

        builder.Property(t => t.Subject).IsRequired(true).HasMaxLength(20);

        builder.HasMany(t => t.TeacherClasses)
            .WithOne(tC => tC.Teacher).HasForeignKey(tC => tC.TeacherID);

        builder.HasMany(t => t.TeacherStudents)
            .WithOne(tC => tC.Teacher).HasForeignKey(tC => tC.TeacherID);
    }
}
