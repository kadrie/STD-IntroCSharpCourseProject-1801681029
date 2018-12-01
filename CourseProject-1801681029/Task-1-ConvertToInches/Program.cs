using System;

namespace Task_1_Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2029 to binary is: {0}.", Convert.ToString(2029, 2));
            Console.WriteLine("2029 to octal is: {0}.", Convert.ToString(2029, 8));
            Console.WriteLine("2029 to heximal is: {0}.", Convert.ToString(2029, 16));
        }
    }
}
