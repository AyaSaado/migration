using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.config
{

    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x=>x.id);
            builder.Property(x=>x.id).ValueGeneratedNever();
            
            builder.Property(x=>x.CourseName)
            .HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();
            
            builder.Property(x=>x.price).HasPrecision(15,2);
            
          //  builder.HasData(getdata());
            builder.ToTable("Courses");
        }

        // private static List<Course> getdata()
        // {
        //     return new List<Course>
        //     {
        //         new Course { id = 1, CourseName = "Mathmatics", price = 1000m},
        //         new Course { id = 2, CourseName = "Physics", price = 2000m},
        //         new Course { id = 3, CourseName = "Chemistry", price = 1500m},
        //         new Course { id = 4, CourseName = "Biology", price = 1200m},
        //         new Course { id = 5, CourseName = "CS-50", price = 3000m},
        //     };
        // }
    }
} 