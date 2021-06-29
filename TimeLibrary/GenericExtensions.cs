using System;

namespace TimeLibrary
{
    public static class GenericExtensions
    {
        public static bool Between<T>(this IComparable<T> sender, T minimumValue, T maximumValue) => sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;
    }
}