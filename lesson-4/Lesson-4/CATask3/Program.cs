using System;

namespace CATask3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }
        static void Main(string[] args)
        {
            Console.Write("Enter numer mouns - only integer (1-12):");
            int.TryParse(Console.ReadLine(), out int numberMounts);            
            Console.WriteLine(SeasonOfMounts(numberMounts));
        }

        static string SeasonOfMounts(int number)
        {
           
            string result = "Enter only an integer from 1 to 12!";
            switch (number)
            {
                case 12:
                case 1:                   
                case 2:
                    result = Convert.ToString(Seasons.Winter);
                    break;
                case 3:                    
                case 4:                    
                case 5:
                    result = Convert.ToString(Seasons.Spring);
                    break;
                case 6:                    
                case 7:                    
                case 8:
                    result = Convert.ToString(Seasons.Summer);
                    break;
                case 9:                    
                case 10:                   
                case 11:
                    result = Convert.ToString(Seasons.Autumn);
                    break;                           
                default:                    
                    break;

            }
            return result;
        }
    }
}
