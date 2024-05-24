using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to convert: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());

            string binary = ConvertDecimalToBinary(decimalNumber);

            Console.WriteLine("Binary: {0}", binary);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string ConvertDecimalToBinary(int decimalNumber)
        {
            string binary = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }
            return binary;

            
        }

        
    }
}
