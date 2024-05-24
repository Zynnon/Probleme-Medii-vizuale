using System;

namespace InterchangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Before interchange:");
            Console.WriteLine("First number: {0}", number1);
            Console.WriteLine("Second number: {0}", number2);

            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine(" ");
            Console.WriteLine("After interchange:");
            Console.WriteLine("First number: {0}", number1);
            Console.WriteLine("Second number: {0}", number2);

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
