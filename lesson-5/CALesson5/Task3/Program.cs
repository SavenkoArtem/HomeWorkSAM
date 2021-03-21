using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = " ";            
            while (true)
            {
                Console.WriteLine("Enter number or 'exit' for quit: ");
                string strUser = Console.ReadLine();
                if (Int32.TryParse(strUser, out int result))
                {
                    if (num == " ")
                    {
                        num = Convert.ToString(result);
                    }
                    else
                    {
                        num = num + $" {result}";
                    }                    
                }
                else
                {
                    if (strUser == "exit")
                    {
                        string[] arrayS = num.Split(' ');
                        int[] arrayN = new int[arrayS.Length];
                        for (int i = 0; i < arrayS.Length; i++)
                        {
                            arrayN[i] = Convert.ToInt32(arrayS[i]);
                        }

                        WriteNumberInByteFile(num); // вызов функции записи в файл
                        WriteNumberInByteFileSer(arrayN); // вызов функции серилазации данных в файл и десереализации
                        return;
                    }                        
                    Console.WriteLine("Please integer only!");
                }                               
            }
            
        }

        // обычная запись в бинарный файл
        public static void WriteNumberInByteFile(string numUser)
        {
            File.WriteAllText("file.bin", numUser);
        }

        // запись в бинарный файл с сериализацией
        public static void WriteNumberInByteFileSer(int[] arrayN)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("fileBS.bin", FileMode.OpenOrCreate);
            formatter.Serialize(fs, arrayN);            
            fs.Position = 0;
            int[] desArrayN = (int[])formatter.Deserialize(fs); // десериализация файла
            foreach (var item in desArrayN)
            {
                Console.WriteLine(item); // вывод сохраненных данных в файл
            }
        }
    }
}
