
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.config
{
    public class SectionCofig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();


            builder.ToTable("Sections");
            
            builder.HasOne(x=>x.Course).
            WithMany(x=>x.Sections)
            .HasForeignKey(x=>x.CourseId).
            IsRequired();
            
            builder.HasOne(x=>x.Instructor).
            WithMany(x=>x.Sections)
            .HasForeignKey(x=>x.InstructorId).
            IsRequired(false);

            builder.HasOne(x=>x.Schedule)
            .WithMany(x=>x.Sections).
            HasForeignKey(x=>x.ScheduleId);

            builder.HasMany(x=>x.particpants)
            .WithMany(x=>x.Sections).
            UsingEntity<Enrollment>();

            builder.OwnsOne(x=>x.TimeSlot, ts=> {
                    ts.Property(p=>p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                    ts.Property(p=>p.EndTime).HasColumnType("time").HasColumnName("EndTime");
            } 
            );    
           // builder.HasData(Load());
        }

        // private static List<Section> Load()
        // {
        //     return new List<Section>
        //     {      
        //         new Section { id = 1, Name = "S_MA1", CourseId = 1, InstructorId = 1 ,ScheduleId = 1, StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00")    },
        //         new Section { id = 2, Name = "S_MA2", CourseId = 1, InstructorId = 2 ,ScheduleId = 3, StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00")    },
        //         new Section { id = 3, Name = "S_PH1", CourseId = 2, InstructorId = 1 ,ScheduleId = 4, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00")    },
        //         new Section { id = 4, Name = "S_PH2", CourseId = 2, InstructorId = 3 ,ScheduleId = 1, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00")    },
        //         new Section { id = 5, Name = "S_CH1", CourseId = 3, InstructorId =2  ,ScheduleId = 1, StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00")    },
        //         new Section { id = 6, Name = "S_CH2", CourseId = 3, InstructorId = 3 ,ScheduleId = 2, StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00")    },
        //         new Section { id = 7, Name = "S_BI1", CourseId = 4, InstructorId = 4 ,ScheduleId = 3, StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00")    },
        //         new Section { id = 8, Name = "S_BI2", CourseId = 4, InstructorId = 5 ,ScheduleId = 4, StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00")    },
        //         new Section { id = 9, Name = "S_CS1", CourseId = 5, InstructorId = 4 ,ScheduleId = 4, StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00")    },
        //         new Section { id = 10, Name = "S_CS2", CourseId = 5, InstructorId =5 , ScheduleId = 3, StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00")   },
        //         new Section { id = 11, Name = "S_CS3", CourseId = 5, InstructorId =4 , ScheduleId = 5, StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00" )  }
        //     };
        // }
    }
}
