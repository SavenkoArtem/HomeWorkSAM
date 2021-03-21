using System;

namespace CATask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameter
            //string numberKkm    = "00042707";
            int numberKkm       = 42707;
            long numberInn       = 7825706086;
            string userPost     = "СИСТ. АДМИНИСТРАТОР";
            int numberCheck     = 8787;
            int numberKassa     = 1;
            string userName     = "Эылдызбек Эльнура";
            float sumReceipt    = 298.15F;
            float inCash        = 1000;
            float change        = 701.85F;
            int eklz            = 872263913;




            //product list
            string[] products = {                           
            "114355 Набор пироженных Муравейник 420г =136,60",
            "305801 Салат Витаминный из мор.капусты   =39,30",
            "1838 Сыр плавл Виола 400г 60%            =96,70",
            "17702 Жев.конфеты Ментос 37г фрукты      =25,55",
            };


            // background color - white
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            // content
            Console.WriteLine("*                ООО \"Агроторг\"               *");
            Console.WriteLine("*г.Пушкин, Авловское ш., д. 23/2 пом.1-Н лит.А*");
            Console.WriteLine("*          Магазин \"Пятерочка\" № 359          *");
            Console.WriteLine(" ");

            string ovNumberKkm = String.Format("{0:D8}", numberKkm);
            string ovNumberInn = String.Format("{0:D12}", numberInn);
            Console.WriteLine($"ККМ {ovNumberKkm}            ИНН {ovNumberInn} #0351");
            Console.WriteLine($"{DateTime.Now}         {userPost}");
            Console.WriteLine($"ПРОДАЖА                                  №{numberCheck}");
            Console.WriteLine(" ");

            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }

            Console.WriteLine("ИТОГО СО СКИДКОЙ");
            Console.WriteLine($"                                        ={sumReceipt}");
            Console.WriteLine($"Касса № {numberKassa}");
            Console.WriteLine($"Покупок: {products.Length} > Кассир {userName}");
            Console.WriteLine($"ИТОГ                                    ={sumReceipt}");
            Console.WriteLine($" НАЛИЧНЫМИ                                ={inCash}");
            Console.WriteLine($"СДАЧА                                   ={change}");
            Console.WriteLine(" ");
            string ovEklz = String.Format("{0:D10}", eklz);
            Console.WriteLine($"        ЭКЛЗ {ovEklz}");
            Console.WriteLine($"        00079094 #010553");




            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }
    }
}
