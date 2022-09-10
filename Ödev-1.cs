using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Değişkenler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 1; //1 byte
            sbyte c = 1; //1 byte

            short s = 2;  //2 byte
            ushort us = 2;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 4;  //4 byte
            Int32 i32 = 4;  //4 byte
            Int64 i64 = 8;  //8 byte

            uint ui = 4; //4 byte
            long l = 8; //8 byte
            ulong ul = 8; //8 byte

            //Reel Sayılar
            float f = 4; //4 byte
            double d = 8; //8 byte
            decimal de = 16; //16 byte

            char ch = '2'; //2 byte
            string str = "melike"; //sinirsiz
            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // Objeler üst türlerdir, her şeyi tanımlayabiliriz.
            object o1 = "a";
            object o2 = 'b';
            object o3 = 4;
            object o4 = 4.3;

            //String

            string str1 = string.Empty; //Değeri boş bir string tanımlama ya da = null; yapılabilir.
            str1 = "melike nazlı";
            string ad = "melike";
            string soyad = "nazlı";
            string ad_soyad = ad + " " + soyad;
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(ad_soyad);

            //integer

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10 < 2;

            // Değişken Dönüşümleri
            string str24 = "24";
            int int24 = 24;
            string yeniDeger = str24 + " " + int24.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int24 + Convert.ToInt32(str24);
            Console.WriteLine(int21);

            // Parse string dönüşümler icin kullanılır.
            int int22 = int24 + int.Parse(str24); // Çıktısı 40

            // datetime

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour1 = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(hour1);
            Console.ReadKey();

        }
    }
}