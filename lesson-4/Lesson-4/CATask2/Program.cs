using System;

namespace CATask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers separated by a space (integer only)");
            string arrayS = Console.ReadLine();
            Console.WriteLine(SumLine(arrayS));
        }

        static string SumLine(string s)
        {

            string[] numbers  = s.Split(' ');
            int result = 0;            
            foreach (var num in numbers)
            {
                if(int.TryParse(num, out int intNum))
                {                     
                    result = result + intNum;
                }
                else
                {
                    Console.WriteLine("integer only!");
                    break;
                }
            }
            return Convert.ToString(result);
        }
    }
}
