using System;
using System.Data;

namespace TimeSpanDataTable
{
    public static class Extensions
    {
        public static bool IsNullOrWhiteSpace(this string sender) => string.IsNullOrWhiteSpace(sender);
        public static TimeSpan ToTimeSpan(this string sender) => TimeSpan.Parse(sender);
        public static bool IsValidTimeFormat(this string sender) => TimeSpan.TryParse(sender, out _);
        public static T GetValue<T>(this IDataReader sender, string columnName)
        {
            var value = sender[columnName];
            return value == DBNull.Value ? default : (T)value;
        }
    }
}