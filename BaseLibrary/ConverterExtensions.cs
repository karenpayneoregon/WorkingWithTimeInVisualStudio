namespace BaseLibrary
{
    public static class ConverterExtensions
    {
        public static bool IsNumeric(this string input)
        {
            return int.TryParse(input, out int number);
        }
    }
}
