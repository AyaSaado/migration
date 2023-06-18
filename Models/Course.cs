using System;
namespace Models
{

    public class Course
    {
        public int id {get ; set ;}
        public string? CourseName {get ; set ;}

        public decimal price {get ; set ;}

        public ICollection<Section> Sections {get;set;} = new List<Section>();  
    }
}
