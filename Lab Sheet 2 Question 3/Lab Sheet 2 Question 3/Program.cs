namespace Lab_Sheet_2_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();

            Console.WriteLine("Enter temperatures for the week (in Celsius):");
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Day {i + 1}: ");
                tracker.Temperatures[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nWeekly Temperature Report:");
            tracker.DisplayTemperatures();
        }
    }

    class TemperatureTracker
    {
        // Array to store daily temperatures
        public float[] Temperatures = new float[7];

        // Method to display temperatures
        public void DisplayTemperatures()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {Temperatures[i]} °C");
            }
        }
    }
}
