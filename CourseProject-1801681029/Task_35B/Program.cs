﻿using System;

namespace Task_35B
{
    // Задачата е решена правилно, но с едно методче ще изглежда по елегантно. Условие?
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter number for a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter number for b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter number for c");
                double c = double.Parse(Console.ReadLine());

                if (a != 0)
                {
                    double D = (b * b) - (4 * a * c);

                    if (D < 0)
                    {
                        Console.WriteLine(true);
                        Console.WriteLine($"There are no real roots for this equation and D is {D} ");
                    }
                    else if (D == 0)
                    {
                        Console.WriteLine(false);
                        double x = -(b / (2 * a));
                        Console.WriteLine($"In this case D is {D} and x1 = x2 = {x} ");
                    }
                    else if (D > 0)
                    {
                        Console.WriteLine(false);
                        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine($"In this case D is {D} , x1 is {x1} and x2 is {x2}");
                    }
                    else
                    {
                        Console.WriteLine("There is something wrong!");
                    }
                }
                else
                {
                    Console.WriteLine(" The parameter 'a' cannot be 0 !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
