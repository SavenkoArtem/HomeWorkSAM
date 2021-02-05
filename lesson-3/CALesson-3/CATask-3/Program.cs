using System;

namespace CATask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your text: ");
            string textUser = Console.ReadLine();
            Console.WriteLine();

            int k = textUser.Length - 1;
            for (int i = 0; i < textUser.Length; i++, k--)
            {
                Console.Write($"{textUser[k]}");
            }
        }
    }
}
