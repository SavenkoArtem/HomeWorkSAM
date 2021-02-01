using System;

namespace CAtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the minimum temperature per day (number only): ");
            if (float.TryParse(Console.ReadLine(), out float minTemp))
            {
                Console.WriteLine(minTemp);
            }
            else
            {
                Console.WriteLine("Please number only!");
            }

            Console.Write("Enter the maximum temperature per day(number only): ");
            if (float.TryParse(Console.ReadLine(), out float maxTemp))
            {
                Console.WriteLine(maxTemp);
            }
            else
            {
                Console.WriteLine("Please number only!");
            }

            float averageTemp = (minTemp + maxTemp)/2;
            Console.WriteLine($"Average temperature is {averageTemp}");
            
        }
    }
}
