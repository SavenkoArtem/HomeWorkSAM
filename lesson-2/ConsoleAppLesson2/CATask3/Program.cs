using System;

namespace CATask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if(Int32.TryParse(Console.ReadLine(), out int number))
            {
                if (number/2 == 0)
                {
                    Console.WriteLine("This number is even!");
                }
                else
                {
                    Console.WriteLine("This number is uneven");
                }

            }
            else
            {
                Console.WriteLine("Enter integer only!");
            }
        }
    }
}
