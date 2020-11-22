using System;
using System.ComponentModel;
using System.Dynamic;

namespace C_Sharp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //KODLARIN ÇALIŞMASI İÇİN SIRAYLA YORUM SATIRINDAN ÇIKARILMASI GEREKİR.

            
            //INTEGERI DOUBLE DÖNÜŞTÜRME
            //int MyInt = 5;
            //double MyDouble = MyInt;
            //Console.WriteLine(MyDouble);


            //DOUBLE INTEGERA DÖNÜŞTÜRME
            //double MyDouble = 8.85;
            //int MyInt = (int)MyDouble;
            //Console.WriteLine(MyInt);


            //KARIŞIK TİP DÖNÜŞÜMLERİ
            //int MyInt = 5;
            //double MyDouble = 8.85;
            //bool myBool = true;
            //Console.WriteLine(Convert.ToString(MyInt));         //5
            //Console.WriteLine(Convert.ToDouble(MyInt));         //5
            //Console.WriteLine(Convert.ToInt32(MyDouble));       //9
            //Console.WriteLine(Convert.ToString(myBool));        //true


            //Console.WriteLine("Kullanıcı adını giriniz: ");   //konsola girilen değer string olarak algılanır.
            //string kullaniciAdi = Console.ReadLine();     //Girilen değeri okur
            //Console.WriteLine("Kullanıcı adınız: "+kullaniciAdi);


            //Console.WriteLine("Yaşınızı giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());  //Ekrana girilen değer otomatik olarak string alınıyordu. O yüzden integera dönüştürüldü.
            //Console.WriteLine($"Yaşınız: {yas} ");


            //int a = 5;
            //int b = 4;
            //int c = 2;
            //int toplam = a + b * c;
            //Console.WriteLine("İşlemin sonucu= " +toplam);


            //double x = 7;
            //double y = 4;
            //double c = 3;
            //double d = (x + y) / c;
            //double e = (x + y) % c;
            //Console.WriteLine("İşlemin sonucu = " + d);
            //Console.WriteLine("İşlemin sonucu = " +e);


            //int a = 5;
            //a++;
            //Console.WriteLine(a);






            //MATEMATİK KÜTÜPHANESİ

            //double x = 7;
            //double y = 4;
            //Console.WriteLine(Math.Pow(x,y));

            //double karekok = Math.Sqrt(16);
            //Console.WriteLine(karekok);

            //double a = 9.88;
            //double b = Math.Round(a);
            //Console.WriteLine(b);




            //MANTIKSAL OPERATÖRLER   ==, !=, >, <, <=, >=, &&, ||

            //int a = 5;
            //int b = 4;
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a != b && a == 5);    //Bir taraf yanlış ise false döner.
            //Console.WriteLine(a == b || a != 5);    //Bir taraf doğru ise true döner.







            //ALIŞTIRMALAR

            //1.soru
            //int a = 2;
            //int b = 8;
            //Console.WriteLine(a+(b/2));

            //2.soru
            //int a = 10;
            //int b = 2;
            //int c = 8;
            //Console.WriteLine((a/b) * c - 1);

            //3. soru
            //int x = 5;
            //int y = 4;
            //double z = Math.Pow(x, y);
            //Console.WriteLine((z+y*x)/3);


            //4.soru
            //int c = 13;
            //double b = 8;
            //int a = 3;
            //double x = Math.Sqrt(Math.Pow(b, 2) - a * c) / 5;
            //Console.WriteLine(x);

        }
    }
}
