﻿using System;

namespace Task_209J
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Generate 100 random numbers [0,132] and print thoose from them:
            //          -which doesn't belong in the interval (26,100]
            try
            {
                Console.WriteLine("These are the numbers which are not in the interval (26,100]");
                Console.WriteLine("------------------------------------------------------------");

                Random rand = new Random();
                int number = 0;
                for (int i = 0; i < 100; i++)
                {
                    number = rand.Next(0, 132);

                    if (number >= 100 || number < 26)
                    {
                        Console.WriteLine(number);
                    }
                }
                Console.WriteLine("------------------------------------------------------------");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
