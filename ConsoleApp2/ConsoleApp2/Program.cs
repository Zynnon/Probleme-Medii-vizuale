using System;
using System.Collections.Generic;

namespace StoreAndDisplayNumbers
{
    class Program
    {
          static void Main(string[] args)
        {
            List<float> numbers = new List<float>();
            float number;
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                number = Convert.ToSingle(input);

                // Check if the number ends in two zeros
                if (number % 100 == 0)
                {
                    break;
                }
                numbers.Add(number);
            }
            Console.WriteLine("You entered the following numbers:");
            foreach (float num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
