namespace Lab_Sheet_1_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of all numbers from 1 to {n} is: {sum}");
            }
        }
    }
}
