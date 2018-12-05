using System;
using System.Linq;

namespace Task_372_AJ
{
    // Тия eCounter и rCounter май само ти си ги знаеш за какво са. Без условие.... Два метода също могат да бъдат изнесени.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a few cities.");
                string[] cities = new string[3];

                for (int i = 0; i < cities.Count(); i++)
                {
                    Console.WriteLine($"Enter city {i + 1}");

                    cities[i] = Console.ReadLine();
                }

                foreach (var city in cities)
                {
                    int eCounter = 0;
                    int rCounter = 0;
                    for (int i = 0; i < city.Length; i++)
                    {
                        if (city[i] == 'e' || city[i] == 'E')
                        {
                            eCounter++;
                        }
                        else if (city[i] == 'r')
                        {
                            rCounter++;
                        }
                    }
                    if (eCounter >= 2 && eCounter <= 4 && rCounter == 0)
                    {
                        Console.WriteLine($"The cities, which contain 'E' or 'e' 2, 3 or 4 times and don't contain 'r' are:  {city}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
