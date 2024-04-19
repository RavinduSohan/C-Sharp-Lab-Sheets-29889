namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, width;

            Console.WriteLine("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());

            CalculateArea(length, width);

            Console.ReadLine();
        }

       static void CalculateArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
