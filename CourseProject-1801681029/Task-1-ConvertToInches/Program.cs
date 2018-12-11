using System;

namespace Task_1_Convertion
{
    class Program
    {
        // Convert 2029 to binary, octal and heximal 
        static void Main(string[] args)
        {
            int numberToConvert = 2029;
            Console.WriteLine($"{numberToConvert} to binary is: " + Convert.ToString(numberToConvert, 2));
            Console.WriteLine($"{numberToConvert} to octal is: " + Convert.ToString(numberToConvert, 8));
            Console.WriteLine($"{numberToConvert} to heximal is: " + Convert.ToString(numberToConvert, 16));
        }
    }
}
