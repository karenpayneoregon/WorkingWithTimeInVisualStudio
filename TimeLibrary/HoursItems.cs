using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLibrary
{
    public class HoursItems
    {
        public List<HourItem> HourItems { get; set; }
        public void Range(TimeIncrement pTimeIncrement = TimeIncrement.Hourly)
        {

            const string timeFormat = "hh:mm tt";

            var hours = Enumerable.Range(0, 24).Select((index) => 
                (DateTime.MinValue.AddHours(index)));

            var hourItemsList = new List<HourItem>();

            foreach (var dateTime in hours)
            {

                hourItemsList.Add(new HourItem()
                {
                    DisplayValue = dateTime.ToString(timeFormat), 
                    TimeSpan = dateTime.TimeOfDay
                });

                if (pTimeIncrement == TimeIncrement.Quarterly)
                {
                    hourItemsList.Add(new HourItem()
                    {
                        DisplayValue = dateTime.AddMinutes(15).ToString(timeFormat), 
                        TimeSpan = dateTime.AddMinutes(15).TimeOfDay
                    });
                    
                    hourItemsList.Add(new HourItem()
                    {
                        DisplayValue = dateTime.AddMinutes(30).ToString(timeFormat), 
                        TimeSpan = dateTime.AddMinutes(30).TimeOfDay
                    });
                    
                    hourItemsList.Add(new HourItem()
                    {
                        DisplayValue = dateTime.AddMinutes(45).ToString(timeFormat), 
                        TimeSpan = dateTime.AddMinutes(45).TimeOfDay
                    });
                    
                }
                else if (pTimeIncrement == TimeIncrement.HalfHour)
                {
                    hourItemsList.Add(new HourItem()
                    {
                        DisplayValue = dateTime.AddMinutes(30).ToString(timeFormat), 
                        TimeSpan = dateTime.AddMinutes(30).TimeOfDay
                    });
                }
            }

            HourItems = hourItemsList;

        }
    }

    public class HourItem
    {
        public string DisplayValue { get; set; }
        public TimeSpan TimeSpan { get; set; }
        /// <summary>
        /// Display time in ComboBox
        /// </summary>
        public override string ToString() => DisplayValue;

    }
}
