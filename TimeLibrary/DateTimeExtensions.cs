using BaseLibrary;
using System;
using System.Globalization;
using System.Text;


namespace TimeLibrary
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert TimeSpan into DateTime
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        /// <remarks>
        /// Intended to be used when the date part does not matter
        /// </remarks>
        public static DateTime ToDateTime(this TimeSpan sender) => 
            DateTime.ParseExact(sender.Formatted("hh:mm"), "H:mm", null, DateTimeStyles.None);

        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns></returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt") => 
            DateTime.Today.Add(sender).ToString(format);

        /// <summary>
        /// Create TimeSpan with hour and minutes
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public static TimeSpan TimeSpan(int hours, int minutes) => 
            new TimeSpan(hours,minutes,0);

        /// <summary>
        /// Returns a valid TimeSpan from string if string
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static TimeSpan TimeSpan(this string sender)
        {
            var sb = new StringBuilder(sender);
            var result = sb.Replace(" AM", string.Empty).Replace(" PM", string.Empty).ToString();
            var tmp = result.Replace(":", "");
            if (tmp.IsNumeric())
            {
                try
                {
                    return System.TimeSpan.ParseExact(result, "h\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None);

                }
                catch (FormatException)
                {
                    return new TimeSpan();
                }
            }
            else
            {
                return new TimeSpan();
            }
        }
        /// <summary>
        /// Convert string to TimeSpan with zero assertion.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static TimeSpan TimeSpanExact(this string sender)
        {
            var parts = sender.Split(':');
            var hour = Convert.ToInt32(parts[0]);
            var min = Convert.ToInt32(parts[1]);
            return new TimeSpan(hour, min, 0);
        }



        /// <summary>
        /// Is end time prior to start time
        /// </summary>
        /// <param name="endTimeSpan"></param>
        /// <param name="startTimeSpan"></param>
        /// <returns></returns>
        public static bool IsValidEndTime(this TimeSpan endTimeSpan, TimeSpan startTimeSpan)
        {
            return endTimeSpan.Hours < startTimeSpan.Hours;
        }
        /// <summary>
        /// Is start time after end time
        /// </summary>
        /// <param name="startTimeSpan"></param>
        /// <param name="endTimeSpan"></param>
        /// <returns></returns>
        public static bool IsValidStartTime(this TimeSpan startTimeSpan, TimeSpan endTimeSpan) => 
            endTimeSpan.Hours > startTimeSpan.Hours;

        /// <summary>
        /// Given a date time round down to the closest quarter
        /// </summary> 
        /// <param name="dateTime">Base datetime object to round down</param>
        /// <returns>Rounded datetime to closes quarter</returns>
        public static DateTime RoundDown15Minutes(this DateTime dateTime)
        {
            return new DateTime(
                dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, (dateTime.Minute / 15) * 15, 0);
        }
        /// <summary>
        /// Round up by minutes DateTime.Now.RoundUp(TimeSpan.FromMinutes(15))
        /// </summary>
        /// <param name="dateTime">Base datetime object to round up.</param>
        /// <param name="timeSpan">Timespan interval for rounding</param>
        /// <returns>Rounded datetime</returns>
        public static DateTime RoundUp(this DateTime dateTime, TimeSpan timeSpan)
        {
            return new DateTime(
                (dateTime.Ticks + timeSpan.Ticks - 1) / timeSpan.Ticks * timeSpan.Ticks, dateTime.Kind);
        }
        /// <summary>
        /// Truncate to current hour
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime TruncateToHourStart(this DateTime dateTime) => 
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);

        /// <summary>
        /// Truncate to current minute
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime TruncateToMinuteStart(this DateTime dateTime) => 
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0);

        /// <summary>
        /// Combine date and time
        /// </summary>
        /// <param name="day">Valid Initialized DateTime</param>
        /// <param name="time">Valid initialized TimeSpan</param>
        /// <returns></returns>
        public static DateTime At(this DateTime day, TimeSpan time) => 
            new DateTime(day.Year, day.Month, day.Day, 0, 0, 0).Add(time);

        /// <summary>
        /// Combine date and time
        /// </summary>
        /// <param name="day">Valid Initialized DateTime</param>
        /// <param name="time">Valid initialized TimeSpan</param>
        /// <returns></returns>
        public static DateTime And(this DateTime day, TimeSpan time) => day.Add(time);

        public static TimeSpan ToTimeSpan(this string sender)
        {
            DateTime.TryParseExact(sender, "HH:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime);
            return dateTime.TimeOfDay;
        }
    }
}
