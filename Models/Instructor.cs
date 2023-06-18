namespace Models
{
    public class Instructor
    {
        public int id { get; set; }
        public string? FName { get; set; }

        public string? LName { get; set; }

        public int? OfficeId { get; set; }
        public Office? office { get; set; }

        public ICollection<Section> Sections {get;set;} = new List<Section>();  
    }
}
