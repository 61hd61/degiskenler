using System;
using System.Data.Common;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // string ifadeler
            string str1 = string.Empty;
            str1 = "Hakan DURMUŞ";
            string ad = "Hakan";
            string soyad = "DURMUŞ";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekillleri
            int int1 = 5;
            int int2= 3;
            int int3 = int1 * int2;

            // boolean 

            bool bool1 = 10 > 2;
            Console.WriteLine(bool1);

            // değişken dnüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeğer = str20 + int20.ToString();
            Console.WriteLine(yeniDeğer);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);


            // dateTime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(dateTime1);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);










        
        }
    }
}

