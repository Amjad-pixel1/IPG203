namespace LibrarySystem.Utilities
{
    public static class Validator
    {
        public static bool IsValidString(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool IsPositiveNumber(int value)
        {
            return value > 0;
        }
    }
}