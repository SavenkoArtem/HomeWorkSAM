using System;

namespace CATask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;
            matrix[2, 2] = 3;
            matrix[3, 3] = 4;
            matrix[4, 4] = 5;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{ matrix[i, j]} ");
                }
                Console.WriteLine();
            }


            // ---------------------------------- Variant 2 ---------------------------
            Console.WriteLine();
            string[,] matrixS = new string[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
