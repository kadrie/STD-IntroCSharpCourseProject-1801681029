using System;

namespace Task_402
{
    // ??
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                int n = 0;

                do
                {
                    Console.Write("n <= 31, n = ");
                    n = int.Parse(Console.ReadLine());
                }

                while (n > 31 || n < 0);
                double[] A = new double[n];
                double[] B = new double[n];
                double[] C = new double[n];

                Console.WriteLine("Enter amount of rain for A");
                FillData(A, n);

                Console.WriteLine("Enter amount of rain for B");
                FillData(B, n);

                Console.WriteLine("Enter amount of rain for C");
                FillData(C, n);

                double minA = FindMin(A);
                Console.WriteLine($"Minimal amount of rain for A: {minA} ");

                double minB = FindMin(B);
                Console.WriteLine($"Minimal amount of rain for B: {minB} ");

                double minC = FindMin(C);
                Console.WriteLine($"Minimal amount of rain for C: {minC} ");

                Console.WriteLine("Days in which the amount of rain is equal to the minimal amount of rain for A: ");
                FindMinDays(A, minA);

                Console.WriteLine("Days in which the amount of rain is equal to the minimal amount of rain for B:");
                FindMinDays(B, minB);

                Console.WriteLine("Days in which the amount of rain is equal to the minimal amount of rain for C:");
                FindMinDays(C, minC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void FindMinDays(double[] arr, double min)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    Console.WriteLine($"Day {i + 1}");
                }
            }
        }

        static double FindMin(double[] arr)
        {
            double min = double.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static void FillData(double[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber >= 0)
                {
                    arr[i] = currentNumber;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    i--;
                }
            }
        }
    
    }
}
