namespace Algorithms
{
    public static class Fibonacci
    {
        public static long Calculate(long number)
        {
            if (number < 2)
                return number;

            return Calculate(number - 1) + Calculate(number - 2);
        }
    }
}
