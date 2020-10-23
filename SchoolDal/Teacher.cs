using System.Collections.Generic;

namespace SchoolDal
{
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string email, Address address, List<Subject> subjects) : base(firstName, lastName, email, address)
        {
            Subjects = subjects;
        }

        public Teacher(string firstName, string lastName, string email, Address address) : base(firstName, lastName, email, address)
        {
            Subjects = new List<Subject>();
        }

        public List<Subject> Subjects { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Subjects)}: {Subjects}";
        }
    }
}