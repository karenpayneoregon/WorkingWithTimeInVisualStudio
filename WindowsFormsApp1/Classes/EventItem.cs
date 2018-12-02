using System;

namespace WindowsFormsApp1.Classes
{
    public class EventItem
    {
        public int EventID { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $"id: [{EventID}] Start: '{StartTime}' End: '{EndTime}'";
        }
    }
}
