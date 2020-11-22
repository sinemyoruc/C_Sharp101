using System;
using System.Numerics;

namespace C_Sharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = 0; // degişkenimiz
            Console.BackgroundColor = ConsoleColor.Black; //arka plan rengi
            Console.ForegroundColor = ConsoleColor.Green; //yazı rengi
            Console.Clear(); // konsolu temizleme


            Console.Write("ismin:"); //konsoldan metinsel veri alıyoruz
            String b = Console.ReadLine();//alınacak veri girişi


            while (true) // döngümüz
            {
                DateTime zaman = DateTime.Now; //zamanı bilgisayardan alma

                a += 1;
                //Console.Write(a);// degişkenimiz
                //Console.Write("=");//boşluk
                // Console.WriteLine("Selam"); // mesajımız

                Console.WriteLine($"{a}=Selam {b}"); // ekrana degişken ile yazı yazma

                System.Threading.Thread.Sleep(1000);//delay kodu


                if (a > 9) //eger a degişkeni 10 un üzerinde ise bu kodu çalıştır
                {

                    Console.WriteLine($"10 kere yazıldı ve başa döndü Zaman--> {zaman}");// ekrana zaman yazma
                    a = 0; //a degişkenini sıfırla



                }
            }

        }

    }

}
