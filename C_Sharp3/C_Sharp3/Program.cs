using System;

namespace C_Sharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF-ELSE YAPISI


            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 10){    //Ekrana girilen sayı 10dan küçük mü?
            //    Console.WriteLine("Girilen sayı 10dan büyüktür.");
            //}
            //else{          //IF KOŞULU SAĞLANMIYORSA
            //    Console.WriteLine("Girilen sayi 10dan küçüktür.");
            //}




            //EKRANDAN GİRİLEN SAYI TEK Mİ ÇİFT Mİ BULAN KOD
            //while (true)
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());     //Int32.Parse() ile de inte dönüştürülebilir.

            //    if (sayi2 % 2 == 0)
            //    {
            //        Console.WriteLine($"Girdiğiniz sayi: {sayi2} ve çifttir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Girdiğiniz sayı: {sayi2} ve tektir.");
            //    }
            //}




            //ÖRNEK:FİYAT KARAR KODU
            //while (true)
            //{
            //    Console.WriteLine("Çorbanın fiyatı ne kadar? ");
            //    int corbaFiyat = Int32.Parse(Console.ReadLine());
            //    if(corbaFiyat >= 10)
            //    {
            //        Console.WriteLine($"{corbaFiyat} TL çorba pahalı.");
            //    }
            //    else if(5 <= corbaFiyat && corbaFiyat < 10){
            //        Console.WriteLine($"{corbaFiyat} TL uygun.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{corbaFiyat} TL çorba içmesen iyi olur.");
            //    }
            //}




            //LOGIN UYGULAMASI

            //while (true)
            //{
            //    string kullanici = "sinem_123*";
            //    string parola = "1234";
            //    Console.Write("Kullanıcı adını giriniz: ");
            //    string kullaniciAdi = Console.ReadLine();
            //    if (kullaniciAdi == kullanici)
            //    {
            //        Console.Write("Kullanıcı adı onaylandı. Şifre giriniz: ");
            //        string sifre = Console.ReadLine();
            //        if (parola == sifre)
            //        {
            //            Console.WriteLine("Sifre onaylandı. Giriş yapılıyor...");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Şifre hatalı. Tekrar deneyiniz.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalı. Tekrar deneyiniz.");
            //    }

            //}




            //YUKARIDAKİ KODUN DAHA DOĞRU ŞEKLİ

            //while (true)
            //{
            //    string kullanici = "sinem_123*";
            //    string parola = "1234";

            //    Console.Write("Kullanıcı Adını Giriniz: ");
            //    string kullaniciAdi = Console.ReadLine();

            //    Console.Write("Parola Giriniz: ");
            //    string kullaniciParola = Console.ReadLine();

            //    if(kullaniciAdi == kullanici && kullaniciParola == parola) //İki ihtimal de doğruysa if bloğu çalışır.
            //    {
            //        Console.WriteLine("GİRİŞ BAŞARILI...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("KULLANICI ADI YA DA PAROLA YANLIŞ. TEKRAR DENEYİNİZ...");
            //    }
            //}



            //FOR DÖNGÜSÜ

            //for(int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine($"{i} Sinem");
            //}


        }
    }
}
