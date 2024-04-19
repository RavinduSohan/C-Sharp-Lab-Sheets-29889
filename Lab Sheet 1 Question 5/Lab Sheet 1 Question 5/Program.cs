namespace Lab_Sheet_1_Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you wish to see the multiplication table for : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {num}:");

            for (int i = 1; i <= 10; i++)
            {
                int product = num * i;
                Console.WriteLine($"{num} x {i} = {product}");
            }
        }
    }
}
