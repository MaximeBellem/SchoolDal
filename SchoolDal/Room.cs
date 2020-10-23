using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDal
{
    public class Room
    {
        public Room(string name, List<Course> courses)
        {
            Name = name;
            Courses = courses;
        }

        public Room(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Courses)}: {Courses}";
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}