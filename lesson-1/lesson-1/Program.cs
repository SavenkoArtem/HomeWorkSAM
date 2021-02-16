using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name: ");
            string user_name = Console.ReadLine();            
            Console.WriteLine($"Hi, {user_name}, today is {DateTime.Now.ToString("dd-MM-yyyy")}.");
        }
    }
}
