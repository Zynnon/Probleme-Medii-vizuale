using System;

namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            float number1 = Convert.ToSingle(input1);

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            float number2 = Convert.ToSingle(input2);

            float sum = number1 + number2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);


            string input3 = Console.ReadLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
