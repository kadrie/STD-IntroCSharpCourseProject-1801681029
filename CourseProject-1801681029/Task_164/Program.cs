using System;

namespace Task_164
{
    class Program
    {
        static void Main(string[] args)
        {
            //There are given coordinates of a triangle. Create methods:
            //To check if triangle with the given coordinates can exist.
            //To find triangle's area if the previous one is TRUE.            

            // Пробвай да изкараш няколко метода от този try-catch. Аз виждам поне 3-и метода, които могат да се изведат.
            try
            {
                Console.WriteLine("Enter Xa.");
                double xA = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Ya.");
                double yA = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Xb.");
                double xB = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Yb.");
                double yB = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Xc.");
                double xC = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Yc.");
                double yC = double.Parse(Console.ReadLine());

                Console.WriteLine($"Point A ({xA} , {yA})");
                Console.WriteLine($"Point B ({xB} , {yB})");
                Console.WriteLine($"Point C ({xC} , {yC})");
                Console.WriteLine("------------------------------");

                double coordinatesXOfAB = Math.Abs(xB - xA);
                double coordinatesYOfAB = Math.Abs(yB - yA);
                double lenghtOfAB = Math.Sqrt((coordinatesXOfAB * coordinatesXOfAB) + (coordinatesYOfAB * coordinatesYOfAB));

                Console.WriteLine($"this is the lenght of AB {lenghtOfAB}");
                Console.WriteLine("-----------------------------");

                double coordinatesXOfBC = Math.Abs(xC - xB);
                double coordinatesYOfBC = Math.Abs(yC - yB);
                double lenghtOfBC = Math.Sqrt((coordinatesXOfBC * coordinatesXOfBC) + (coordinatesYOfBC * coordinatesYOfBC));
                Console.WriteLine($"this is the leght of BC {lenghtOfBC}");
                Console.WriteLine("------------------------------");
                double coordinatesXOfAC = Math.Abs(xC - xA);
                double coordinatesYOfAC = Math.Abs(yC - yA);
                double lenghtOfAC = Math.Sqrt((coordinatesXOfAC * coordinatesXOfAC) + (coordinatesYOfAC * coordinatesYOfAC));
                Console.WriteLine($"this is the leght of AC {lenghtOfAC}");
                Console.WriteLine("------------------------------");
                double a = lenghtOfBC;
                double b = lenghtOfAC;
                double c = lenghtOfAB;

                if (a + b > c && a + c > b && b + c > a)
                {
                    double perimeterOfTriangle = lenghtOfAB + lenghtOfAC + lenghtOfBC;
                    Console.WriteLine("that triangle exist");
                    Console.WriteLine($"the perimeter of that triagnle is {perimeterOfTriangle}");
                    double p = perimeterOfTriangle / 2;
                    double area = Math.Sqrt(p * (p - lenghtOfAC) * (p - lenghtOfAB) * (p - lenghtOfBC));
                    Console.WriteLine($"the area of that triagnle is {area}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("triangle with these coordinates can't exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
