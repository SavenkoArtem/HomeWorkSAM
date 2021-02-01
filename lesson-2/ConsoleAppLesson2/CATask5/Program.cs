using System;

namespace CATask5
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

            float averageTemp = (minTemp + maxTemp) / 2;
            float at = minTemp + maxTemp;

            Console.WriteLine(averageTemp);
            Console.WriteLine(at);

            Console.WriteLine(" ");

            Console.Write("Enter the month number (1-12): ");
            if (Int32.TryParse(Console.ReadLine(), out int numberMount))
            {
                if((numberMount == 12 || numberMount == 1 || numberMount == 2) && (averageTemp > 0))
                {
                    Console.WriteLine("A rainy winter!");
                }
            }
            else
            {
                Console.WriteLine("Please inter only(1-12)!");
                return;
            }
        }
    }
}
