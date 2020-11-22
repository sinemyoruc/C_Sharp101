using System;

namespace C_Sharp5
{
    class Program
    {
        public class Araba
        {
            public string marka;
            public int modelYili;
            public string renk;
            
            public void isimYazdir()
        {
            Console.WriteLine($"{this.marka} ARACINA AİT BİLGİLER:\n\n MODEL: {this.modelYili}\n RENK: {this.renk}\n\n");

        }
        }

        

        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.marka = "Mercedes";
            araba1.modelYili = 2014;
            araba1.renk = "Beyaz";
            //Console.WriteLine($"{araba1.marka} ARACINA AİT BİLGİLER:\n\n MODEL: {araba1.modelYili}\n RENK: {araba1.renk}\n  ");
            araba1.isimYazdir();


            Araba araba2 = new Araba();
            araba2.marka = "Toyota";
            araba2.modelYili = 2016;
            araba2.renk = "Kırmızı";
            //Console.WriteLine($"{araba2.marka} ARACINA AİT BİLGİLER:\n\n MODEL: {araba2.modelYili}\n RENK: {araba2.renk}\n ");
            araba2.isimYazdir();


            Araba araba3 = new Araba();
            araba3.marka = "Mazda";
            araba3.modelYili = 2018;
            araba3.renk = "Kırmızı";
            araba3.isimYazdir();

        }
    }
}
