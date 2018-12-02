using System;
using TimeLibrary;

namespace WindowsFormsApp1.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsValidEndTime => !EndTime.IsValidEndTime(StartTime);
    }
}
