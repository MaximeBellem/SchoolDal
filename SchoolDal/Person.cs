using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolDal
{
    public abstract class Person
    {
        public Person(string firstName, string lastName, string email, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
        }


        //[Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }


        public override string ToString()
        {
            return 
                $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Email)}: {Email}, {nameof(Address)}: {Address}";
        }
    }
}