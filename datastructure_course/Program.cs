namespace System
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int result = Factorial(5);

            Console.WriteLine(result);
        }

        public static int Factorial(int n)
        {
            int result = 0;

            // Caso inductivo
            if(n > 1) result = n * Factorial(n - 1);

            // Caso base
            if (n == 1) result = 1;

            return result;
        }
    }
}
