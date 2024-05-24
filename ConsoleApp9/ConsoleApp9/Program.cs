using System;

namespace PowerCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToThePowerOf(2, 3)); // Output: 8
            Console.WriteLine(ToThePowerOf(5, 5)); // Output: 3125


            string input2 = Console.ReadLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static int ToThePowerOf(int baseNumber, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
    
}
