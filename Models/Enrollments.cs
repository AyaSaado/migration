namespace Models 
{
        public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }

        public Section Section { get; set; } = null!;
        public Particpant Student { get; set; } = null!;
    }

}