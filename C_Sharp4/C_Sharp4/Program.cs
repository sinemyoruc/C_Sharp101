using System;
using System.Threading;

namespace C_Sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR DÖNGÜSÜ

            //Ekrana girilen 5 sayiyi topla sonucu yazdir.
            //int toplam = 0;
            //int sayi;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"{i}. sayiyi giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            //Console.WriteLine("Sayilarin toplami = " + toplam);





            //int toplam = 0;
            //int sayi;
            //Console.WriteLine("1den Kaça kadar olan sayıları toplamak istiyorsunuz?");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= sayi; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam = " + toplam);






            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= i; j++)  //i değişkeni ile gelen satırların içi dolar
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}




            //int ucgen = 9;
            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= ucgen; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    ucgen--;
            //    Console.WriteLine();
            //}


            //for (int i = 10; i >= 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}




            //SWİTCH-CASE YAPISI
            //while (true)
            //{
            //    Console.Write("Hava durumu nasıl?\n 1-Yağmurlu\n 2-Bulutlu\n 3-Güneşli\n");
            //    string durum = Console.ReadLine();
            //    switch (durum)
            //    {
            //        case "Yağmurlu":
            //        case "YAĞMURLU":
            //        case "yağmurlu":
            //        case "1":
            //            Console.WriteLine("Şemsiyeni almalisin.");
            //            break;
            //        case "BULUTLU":
            //        case "Bulutlu":
            //        case "bulutlu":
            //        case "2":
            //            Console.WriteLine("Paltonu almalisin.");
            //            break;
            //        case "Güneşli":
            //        case "GÜNEŞLİ":
            //        case "güneşli":
            //        case "3":
            //            Console.WriteLine("Güneş gözlüğünü almalısın.");
            //            break;
            //        default:
            //            Console.WriteLine("Yanlış değer girildi!!!");
            //            break;
            //    }
            //}





            //  WHILE DONGUSU
            //int a = 1;
            //while (a <= 10)
            //{
            //    Console.WriteLine($"{a}. Merhaba Dünya");
            //    a++;
            //}




            //BİR SAYIDAN 0'A KADAR YAZDIRMA
            //Console.WriteLine("Kaçtan saymak istersin?");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while (sayi >= 0)
            //{
            //    Console.WriteLine(sayi);
            //    Thread.Sleep(1000);
            //    sayi--;
            //}
            //Console.WriteLine("Geri sayim tamamlandi...");
            //Console.Beep();




            //1DEN İSTENEN SAYIYA KADAR YAZDIRMA
            //Console.WriteLine("Kaça kadar saymak istersin?");
            //int sayi = 1;
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //while (sayi2 >= sayi)
            //{
            //    Console.WriteLine(sayi);
            //    Thread.Sleep(1000);
            //    sayi++;
            //}




            //DİZİLER
            //int[] deneme = new int[50];     //50 tane int değerini içerisinde barındıran deneme adında bir dizi oluşturduk.
            //for (int i = 0; i <= deneme.Length ; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //2 elemanlı diziler (syntax göstermek için)
            //int[] x = new int[2];
            //string[] y = new string[2];
            //char[] m = new char[2];
            //bool[] u = new bool[2];
            //double[] k = new double[2];




            //int[] a = { 1, 2, 3, 4, 5, 6, 7 };         //dizilerde indis değeri 0dan başlar.
            //Console.WriteLine(a[1]);             // çıktı: 2 dir.




            //double[] tc = { 11111, 22222, 333333 };
            //for (int i = 0; i < tc.Length; i++)
            //{
            //    Console.WriteLine(tc[i]);
            //}



            //string[] isim = { "ali", "veli", "ahmet", "mehmet", "hasan" };
            //foreach (string isaretci in isim)
            //{
            //    Console.WriteLine(isaretci);
            //}
            //Console.ReadKey();






            //int[] diziler = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(diziler.GetLength(0));     //dizi boyutunu  döndürür.


        }
    }
}
