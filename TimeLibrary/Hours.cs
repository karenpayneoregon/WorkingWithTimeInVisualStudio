using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeLibrary
{
    /// <summary>
    /// Used to create a string array which represent time in a day.
    /// </summary>
    /// <remarks>
    /// To get a range of TimeSpan rather than a string array.
    ///    var hours = new Hours();
    ///    var range = hours.Range(TimeIncrement.Quarterly).ToList().Select(time => time.TimeSpan());
    /// In the above example a specific increment is used. This could easliy be a flexible language
    /// extension method.
    /// </remarks>
    public class Hours
    {
        public string[] Range(TimeIncrement pTimeIncrement = TimeIncrement.Hourly)
        {

            const string timeHhMmTtformat = "hh:mm tt";

            IEnumerable<DateTime> hours = Enumerable.Range(0, 24)
                .Select((index) => (DateTime.MinValue.AddHours(index)));

            var timeList = new List<string>();

            foreach (var dateTime in hours)
            {

                timeList.Add(dateTime.ToString(timeHhMmTtformat));

                if (pTimeIncrement == TimeIncrement.Quarterly)
                {
                    timeList.Add(dateTime.AddMinutes(15).ToString(timeHhMmTtformat));
                    timeList.Add(dateTime.AddMinutes(30).ToString(timeHhMmTtformat));
                    timeList.Add(dateTime.AddMinutes(45).ToString(timeHhMmTtformat));
                }
                else if (pTimeIncrement == TimeIncrement.HalfHour)
                {
                    timeList.Add(dateTime.AddMinutes(30).ToString(timeHhMmTtformat));
                }
            }

            return timeList.ToArray();

        }
    }
}
