namespace Models
{
    public class Section
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }    
        public int?  InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
       
        public TimeSlot TimeSlot {get; set;}
        public ICollection<Particpant> particpants { get; set; } = new List<Particpant>();
    
    }
        public class TimeSlot
        {
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }

            public override string  ToString ()
            {
                return $"{StartTime.ToString("hh\\:mm")}-{EndTime.ToString("hh\\:mm")}";
            }
        }
}