using System;

namespace LibraryUserCard
{
    public class UserCard
    {
        public static void SayHi()
        {
            Console.WriteLine("Hi USER!");            
        }
        
        public static void InfoUserCard(string name, int age, string career)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"User name: {name}");
            if (age!=0)
            { 
                Console.WriteLine($"User age: {age}");
            }
            else
            {
                Console.WriteLine($"User age: ");
            }

            Console.WriteLine($"User career: {career}");
        }
    }
}
