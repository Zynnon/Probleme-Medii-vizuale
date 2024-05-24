using System;

namespace SpeedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance (meters): ");
            double distanceMeters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input time (hours): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input time (minutes): ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input time (seconds): ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Convert total time into seconds
            double totalTimeSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Calculate speeds
            double speedMetersPerSecond = distanceMeters / totalTimeSeconds;
            double speedKilometersPerHour = (distanceMeters / 1000) / (totalTimeSeconds / 3600);
            double speedMilesPerHour = speedKilometersPerHour * 0.621371;

            // Display results
            Console.WriteLine(" ");
            Console.WriteLine("Your speed in meters/sec is {0:F6}", speedMetersPerSecond);
            Console.WriteLine("Your speed in km/h is {0:F5}", speedKilometersPerHour);
            Console.WriteLine("Your speed in miles/h is {0:F4}", speedMilesPerHour);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


            string input2 = Console.ReadLine();

        }
    }
}
