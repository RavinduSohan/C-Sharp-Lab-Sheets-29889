namespace Lab_Sheet_1_Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's exam marks (between 0 and 100): ");
            int marks;

            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid input. Please enter a value between 0 and 100.");
                Console.Write("Enter the student's exam marks (between 0 and 100): ");
            }

            string grade;

            if (marks >= 75 && marks <= 100)
                grade = "A";
            else if (marks >= 60 && marks <= 74)
                grade = "B";
            else if (marks >= 50 && marks <= 59)
                grade = "C";
            else if (marks >= 40 && marks <= 49)
                grade = "D";
            else
                grade = "Failed";

            Console.WriteLine($"\nStudent Name: {name}\nGrade: {grade}");
        }
    }
}
