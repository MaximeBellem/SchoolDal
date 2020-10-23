using System;
using System.Collections.Generic;

namespace SchoolDal
{
    public class Course
    {
        public Course(DateTime dateTime, int duration, List<Group> groups, Subject subject, Room room)
        {
            DateTime = dateTime;
            Duration = duration;
            Groups = groups;
            Subject = subject;
            Room = room;
        }

        public Course()
        {
        }


        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public List<Group> Groups { get; set; }
        public Subject Subject { get; set; }
        public Room Room { get; set; }

        public override string ToString()
        {
            return 
                $"{nameof(Id)}: {Id}, {nameof(DateTime)}: {DateTime}, {nameof(Duration)}: {Duration}, {nameof(Groups)}: {Groups}, {nameof(Subject)}: {Subject}, {nameof(Room)}: {Room}";
        }
    }
}