using System;
using System.Linq;

namespace Task_372_AJ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elements of array are city names, starting with uppercase letter, write methods for:
            //      -Filling the array 
            //      -Printing the names which has 'e' or 'E' 2,3 or 4 times and 'r' doesn't exist
            try
            {
                var cities = FillArray(3);
                if (cities != null)
                {
                    FindNames(cities);
                }
                else
                {
                    Console.WriteLine("Empty array!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static string[] FillArray (int count)
        {
            Console.WriteLine("Enter a few cities.");
            string[] cities = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter city {i + 1}");

                cities[i] = Console.ReadLine();
            }
            return cities;
        }
        private static void FindNames(string[] cities)
        {
            foreach (var city in cities)
            {
                //counter for matching 'e' or 'E' characters
                int eLetterCounter = 0;
                //counter for matching 'r' characters
                int rLetterCounter = 0;

                for (int i = 0; i < city.Length; i++)
                {
                    if (city[i] == 'e' || city[i] == 'E')
                    {
                        eLetterCounter++;
                    }
                    else if (city[i] == 'r')
                    {
                        rLetterCounter++;
                    }
                }
                if (eLetterCounter >= 2 && eLetterCounter <= 4 && rLetterCounter == 0)
                {
                    Console.WriteLine($"The cities, which contain 'E' or 'e' 2, 3 or 4 times and don't contain 'r' are:  {city}");
                }
            }
        }
    }
}
