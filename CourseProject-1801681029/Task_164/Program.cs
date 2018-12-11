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
                double lenghtOfAB = GetLengthFromCoordinates(coordinatesXOfAB, coordinatesYOfAB);
                Console.WriteLine($"this is the lenght of AB {lenghtOfAB}");
                Console.WriteLine("-----------------------------");

                double coordinatesXOfBC = Math.Abs(xC - xB);
                double coordinatesYOfBC = Math.Abs(yC - yB);
                double lenghtOfBC = GetLengthFromCoordinates(coordinatesXOfBC, coordinatesYOfBC);
                Console.WriteLine($"this is the leght of BC {lenghtOfBC}");
                Console.WriteLine("------------------------------");

                double coordinatesXOfAC = Math.Abs(xC - xA);
                double coordinatesYOfAC = Math.Abs(yC - yA);
                double lenghtOfAC = GetLengthFromCoordinates(coordinatesXOfAC, coordinatesYOfAC);
                Console.WriteLine($"this is the leght of AC {lenghtOfAC}");
                Console.WriteLine("------------------------------");

                CheckTriangleExisting(lenghtOfBC, lenghtOfAC, lenghtOfAB);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CheckTriangleExisting(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double perimeterOfTriangle = a + b + c;
                Console.WriteLine("that triangle exist");
                Console.WriteLine($"the perimeter of that triagnle is {perimeterOfTriangle}");
                double p = perimeterOfTriangle / 2;
                double area = Math.Sqrt(p * (p - b) * (p - c) * (p - a));
                Console.WriteLine($"the area of that triagnle is {area}");
            }
            else
            {
                Console.WriteLine("triangle with these coordinates can't exist");
            }
        }
        private static double GetLengthFromCoordinates(double firstCoord, double secondCoord)
        {
            return Math.Sqrt((firstCoord * firstCoord) + (secondCoord * secondCoord));
        }
    }
}
