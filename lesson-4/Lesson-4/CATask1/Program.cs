using System;

namespace CATask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = "y";
            do
            {
                Console.Write("Enter your name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter your patronomic: ");
                string patronomic = Console.ReadLine();
                Console.WriteLine(GetFullName(firstName, lastName, patronomic));

                // Exit the program if the user enters " n"
                Console.WriteLine("Continue? (y/n)");
                q = Console.ReadLine();                

            } while (q != "n");

            
        }

        static string GetFullName(string firstName, string lastName, string patronomic)
        {
            return $"Приветствую, {lastName} {firstName} {patronomic}";
        }

    }
}
