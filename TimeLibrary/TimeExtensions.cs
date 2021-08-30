using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLibrary
{
    public static class TimeExtensions
    {
        public static TimeSpan ToTimeSpan(this string sender) => TimeSpan.Parse(sender);
        public static bool IsValidTimeFormat(this string sender) => TimeSpan.TryParse(sender, out var _);
    }
}
