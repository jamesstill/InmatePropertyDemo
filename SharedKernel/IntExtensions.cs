namespace SharedKernel
{
    public static class IntExtensions
    {
        public static bool IsGreaterThanZero(this int i)
        {
            return (i > 0);
        }

        public static bool IsGreaterThan(this int i, int n)
        {
            return (i > n);
        }

        public static bool IsLessThan(this int i, int n)
        {
            return (i < n);
        }

        public static bool IsBetween(this int i, int x, int y)
        {
            return (i >= x && i <= y);
        }
    }
}
