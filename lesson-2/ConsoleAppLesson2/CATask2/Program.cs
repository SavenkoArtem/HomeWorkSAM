using System;

namespace CATask2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the month number (1-12): ");
            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("Enter a number from 1 to 12");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please inter only!");
                return;
            }
        }
    }
}
