using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {            
            WriteTextInStartUp(); // вызов функции записи даты и времени запуска программы
        }

        // функция записи даты и времени при запуске программы
        public static void WriteTextInStartUp()
        {
            string timeNow = Convert.ToString(DateTime.Now);
            File.AppendAllText("startup.txt", timeNow);
            File.AppendAllText("startup.txt", Environment.NewLine);
        }
    }
}
