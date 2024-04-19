namespace Lab_Sheet_1_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i}: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            }

        }
    }
}
