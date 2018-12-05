using System;

namespace Task_4G
{
    // Условие?? Метод?
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number for a");
                double a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number for b");
                double b = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number for x");
                double x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number for y");
                double y = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number for z");
                double z = int.Parse(Console.ReadLine());

                double result = Math.Pow((y + (6 * a) - 2) / (3 * (x + 6)), 6) - (z / (z + (7 * b)));

                Console.WriteLine($"The result is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
