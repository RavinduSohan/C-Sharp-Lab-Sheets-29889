namespace Lab_Sheet_1_Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"The first {n} terms of the Fibonacci series are:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
