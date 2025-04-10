using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.EntityConfiguration;

public class ClassConfiguration : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder.ToTable("TeacherClasses");

        builder.HasKey(c => c.ClassID);

        builder.Property(c => c.ClassName).
            IsRequired(true).HasMaxLength(15);

        builder.HasIndex(c => c.ClassName).IsUnique(true);

        builder.HasMany(c => c.ClassStudents).WithOne(cS => cS.Class).
            HasForeignKey(cS => cS.ClassID);

        builder.HasMany(c => c.ClassTeachers).WithOne(cS => cS.Class).
            HasForeignKey(cS => cS.ClassID);
    }
}
