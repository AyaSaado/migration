using Microsoft.EntityFrameworkCore;
using Models;

public class Program
{
    static void Main(string[] args)
    {


        using (var context = new AppDBContext())
        {
            var data = context.Sections.
            Include(x => x.Course).
            Include(x => x.Instructor).
            Include(x => x.Schedule);

            Console.WriteLine("| Id |  Course      | Section | Instructor           | Schedule       |Start To End    | SUN | MON | TUE | WED | THU | FRI | SAT |");
            Console.WriteLine("|----|--------------|---------|----------------------|----------------|----------------|-----|-----|-----|-----|-----|-----|-----|");

            foreach (var d in data)
            {
                string sunday = d.Schedule.SUN ? " x" : "";
                string monday = d.Schedule.MON ? " x" : "";
                string tuesday = d.Schedule.TUE ? " x" : "";
                string wednesday = d.Schedule.WED ? " x" : "";
                string thursday = d.Schedule.THU ? " x" : "";
                string friday = d.Schedule.FRI ? " x" : "";
                string saturday = d.Schedule.SAT ? " x" : "";


                Console.WriteLine($"| {d.id.ToString().PadLeft(2, '0')} | {d.Course.CourseName,-12} | {d.Name,-7} | {d.Instructor?.FName + " " + d.Instructor?.LName,-20} | {d.Schedule.Title,-14} | {d.TimeSlot,-14} | {sunday,-3} | {monday,-3} | {tuesday,-3} | {wednesday,-3} | {thursday,-3} | {friday,-3} | {saturday,-3} |");
            }
        }

    
    }
}


//  var query = from c in context.Courses
//                 join s in context.Sections on c.id equals s.CourseId
//                 join i in context.Instructors on s.InstructorId equals i.id
//                 join ss in context.SectionSchedules on s.id equals ss.SectionId
//                 join sc in context.Schedules on ss.ScheduleId equals sc.id
//                 let value = new
//                 {
//                     c.id,
//                     c.CourseName,
//                     s.Name,
//                     i.FName,
//                     i.LName,
//                     sc.Title,
//                     sc.SUN,
//                     sc.MON,
//                     sc.TUE,
//                     sc.WED,
//                     sc.THU,
//                     sc.FRI,
//                     sc.SAT
//                 }
//                 select value;

//     var result = query.ToList();

//     Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-20} {4,-15} {5,-5} {6,-5} {7,-5} {8,-5} {9,-5} {10,-5} {11,-5}",
//         "ID", "CourseName", "SectionName", "InstructorName", "Title", "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT");

//     foreach (var item in result)
//     {
//         Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-20} {4,-15} {5,-5} {6,-5} {7,-5} {8,-5} {9,-5} {10,-5} {11,-5}",
//             item.id, item.CourseName, item.Name, item.FName+" "+item.LName, item.Title, item.SUN, item.MON, item.TUE, item.WED, item.THU, item.FRI, item.SAT);
//     }
