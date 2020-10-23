using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDal
{
    public class Group
    {
        public Group(int number, List<Student> students, List<Course> courses)
        {
            Number = number;
            Students = students;
            Courses = courses;
        }

        public Group(int number)
        {
            Number = number;
            Students = new List<Student>();
            Courses = new List<Course>();
        }


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int Number { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        
        
    }
}