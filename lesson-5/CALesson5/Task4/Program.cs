using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = Directory.GetCurrentDirectory();
            string[] directory = path.Split('\\');            
            string filename = "textPath.txt";           
            string filenameR = "textPathR.txt";           
            SavePathInFile(filename, directory); // вызов функции записи директории в файл
            SavePathInFileRec(directory, filenameR); // вызов функции записи директории в файл с использованием рекурсии
        }

        // функция записи директории в файл 
        public static void SavePathInFile(string file, string[] dir, string s = "|_")
        {            
            foreach (string item in dir)
            {
                File.AppendAllText(file, Environment.NewLine);
                File.AppendAllText(file, $"{s} {item}");                
                s ="  " + s;
            }
        }

        // функция записи директории в файл реализованная с использованием рекурсии
        public static void SavePathInFileRec(string[] dir, string file, string s = "|_", int i = 0)
        {            
            if (i < dir.Length)
            {
                File.AppendAllText(file, Environment.NewLine);
                File.AppendAllText(file, $"{s} {dir[i]}");
                s = "  " + s;
                i++;                
                SavePathInFileRec(dir, file, s, i);
            }
        }
    }
}
