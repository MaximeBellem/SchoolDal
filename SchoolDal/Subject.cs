using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SchoolDal
{
    public class Subject
    {
        
        public Subject(string name, Teacher teacher, List<Course> courses)
        {
            Name = name;
            Teacher = teacher;
            Courses = courses;
        }

        public Subject(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Teacher)}: {Teacher}, {nameof(Courses)}: {Courses}";
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] 
       public string Name { get; set; }

       public Teacher Teacher { get; set; }

       public List<Course> Courses { get; set; }
       
       
       
    }
}