using System;

namespace Task_1_Convertion
{
    // Условие? И ко й туй '2029'? Яде ли се, пие ли се и защо пък да не е '2030'?
    // Ако се повтаря няколко пъти '2029', не е ли по-удобно да е изнесено в променлива?
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
