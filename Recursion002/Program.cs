namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
        }

        public static int Fibonacci(int n)
        {
            int result = 0;

            // caso inductivo /
            if (n > 1)
                result = Fibonacci(n - 1) + Fibonacci(n - 2);

            // caso base
            if (n <= 1)
                result = 1;

            return result;
        }
    }
}
