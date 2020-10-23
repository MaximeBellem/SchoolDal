using System.Collections.Generic;

namespace SchoolDal
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, string email, Address address) : base(firstName, lastName, email, address)
        {
            Groups = new List<Group>();
        }

        public Student(string firstName, string lastName, string email, Address address, List<Group> groups) : base(firstName, lastName, email, address)
        {
            Groups = groups;
        }
        


        public List<Group> Groups { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Groups)}: {Groups}";
        }
    }
}