using System;
using LibraryUserCard;

namespace CATask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserCard.SayHi();

            //Checking for empty values
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) && (Properties.Settings.Default.UserAge == 0) && string.IsNullOrEmpty(Properties.Settings.Default.Career))
            {
                //If they are empty, please fill them in
                Console.WriteLine("Please input your name, age and career.");
                InputUserCard();

            }
            else
            {
                string userName = Properties.Settings.Default.UserName;
                int userAge = Properties.Settings.Default.UserAge;
                string userCareer = Properties.Settings.Default.Career;

                UserCard.InfoUserCard(userName, userAge, userCareer);


                Console.WriteLine("Change the values(write 'yes' or 'no')");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    InputUserCard();
                }
                else
                {
                    Console.WriteLine("Good bye!");
                }
            }

            
            Console.ReadKey();
            
        }

        public static void InputUserCard()
        {
            Console.Write("Input user name:");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Console.Write("Input user career:");
            Properties.Settings.Default.Career = Console.ReadLine();
            Console.Write("Input user age:");
            //Checking to integer
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Properties.Settings.Default.UserAge = result;
            }
            else
            {
                Console.Write("Input integer only!");
                Properties.Settings.Default.UserAge = 0;
            }
            Properties.Settings.Default.Save();
        }
    }
}
