using System;

namespace CATask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] phoneDirectory = new string[5][]{
                new string[] {"Stepan", "724123/e-mail"},
                new string[] {"Stepan", "724123/e-mail"},
                new string[] {"Stepan", "724123/e-mail"},
                new string[] {"Stepan", "724123/e-mail"},
                new string[] {"Stepan", "724123/e-mail"},
            };

            for (int i = 0; i < phoneDirectory.Length; i++)
            {
                for (int j = 0; j < phoneDirectory[i].Length; j++)
                {
                    Console.Write($"{phoneDirectory[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // --------------------- Variant 2 --------------------------------


            string[,] phoneDir = new string[5, 2];
            phoneDir[0, 0] = "Ivan";
            phoneDir[0, 1] = "89245559632/ivan@mail.ru";
            phoneDir[1, 0] = "Petya";
            phoneDir[1, 1] = "89542221144/petya@mail.ru";
            phoneDir[2, 0] = "Stas";
            phoneDir[2, 1] = "89994756644/stas@mail.ru";
            phoneDir[3, 0] = "Nina";
            phoneDir[3, 1] = "89374562187/nina@mail.ru";
            phoneDir[4, 0] = "Lida";
            phoneDir[4, 1] = "89574125869/lida@mail.ru";

            for (int i = 0; i < phoneDir.GetLength(0); i++)
            {
                for (int j = 0; j < phoneDir.GetLength(1); j++)
                {
                    Console.Write($"{phoneDir[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
