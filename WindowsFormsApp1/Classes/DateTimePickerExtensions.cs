using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    public static class DateTimePickerExtensions
    {
        /// <summary>
        /// Return Time portion 
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static TimeSpan Time(this DateTimePicker sender)
        {
            return sender.Value.TimeOfDay;
        }
    }
}
