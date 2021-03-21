using System;
using System.IO;

namespace Task1
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Console.Write("Enter your text to write to the file: ");
            string textUser = Console.ReadLine();
            WriteTextInFile(textUser); // вызов функции записи текста в файл
        }

        // функция записи текста в файл
        public static void WriteTextInFile(string textUser)
        {
            Console.WriteLine(" ");
            File.WriteAllText("newNote.txt", textUser);
        }
    }
}
