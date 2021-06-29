namespace BaseLibrary
{
    public static class ConverterExtensions
    {
        public static bool IsNumeric(this string input) => int.TryParse(input, out int number);
    }
}
