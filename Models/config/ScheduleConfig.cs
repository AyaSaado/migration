using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Enums;

namespace Models.Config
{
    public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedNever();

    

            builder.Property(x => x.Title).
            HasConversion(
                x=>x.ToString() ,
                x=>(ScheduleEnum)Enum.Parse(typeof(ScheduleEnum),x)  
            );
        


            builder.ToTable("Schedules");


          //  builder.HasData(LoadSchedules());
        }

        // private static List<Schedule> LoadSchedules()
        // {
        //     return new List<Schedule>
        //     {
        //         new Schedule { id = 1, Title = "Daily", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false },
        //         new Schedule { id = 2, Title = "DayAfterDay", SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = false },
        //         new Schedule { id = 3, Title = "Twice-a-Week", SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false },
        //         new Schedule { id = 4, Title = "Weekend", SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true },
        //         new Schedule { id = 5, Title = "Compact", SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true }
        //     };
        // }

    
    }
}