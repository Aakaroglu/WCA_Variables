using System;

namespace First_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //tam sayılar
            //tam sayı değişken tipleri , byte sbyte short ushort int uitn long ulong
            byte sayi1 = 56;
            sbyte sayi2 = 12; //ctrl + Sol tık konum şeyine götürü rangesini gösterir
            //ondalıklı sayılar
            //float double decimal
            //metinsel 
            //char string
            //mantıklas
            //boolean
            short sayi3 = 132;
            ushort sayi4 = 123;
            int sayi5 = 324;
            float sayi9 = 12;
            double sayi10 = 546;
            decimal sayi11 = 12;
            char karakter = 'A';
            string metin = "Bilge Adam Akademi"; // \n dersek aralara alt satıra geçirir
            string tekKarakter = "A";
            Console.WriteLine(metin);
            string tabBosluk = "Bilge\tAdam";
            Console.WriteLine(tabBosluk);

            string metin1 = "Bilge Adam Beşiktaş \"Yazılım\" Dersleri";
            Console.WriteLine(metin1);
            bool sonuc = false;
            bool result = 10 > 2;
            Console.WriteLine(result);
        }
    }
}
