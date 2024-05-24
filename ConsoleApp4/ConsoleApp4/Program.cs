using System;

namespace SolveLinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the coefficient a (a != 0): ");
            double a = Convert.ToDouble(Console.ReadLine());

            while (a == 0)
            {
                Console.WriteLine("Coefficient a cannot be zero. Please enter a non-zero value for a.");
                Console.Write("Enter the coefficient a (a != 0): ");
                a = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Enter the coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = -b / a;

            Console.WriteLine("The solution for the equation {0}*x + {1} = 0 is x = {2}", a, b, x);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            string input1 = Console.ReadLine();
        }
    }
}
