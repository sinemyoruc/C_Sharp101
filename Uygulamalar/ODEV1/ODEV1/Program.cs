using System;

namespace ODEV1
{
    class Program
    {

        //SİNEM YORUÇ

        public class Tasitlar
        {
            string tasitTuru;
            public string TasitTuru { get {return tasitTuru; } set {tasitTuru = value; } }

            int hiz;
            public int Hiz { get { return hiz; } set { hiz = value; } }

           public virtual void Yazdir()
                {
                    Console.WriteLine($"Taşıt Türü: {this.tasitTuru}\nMax Hız: {this.hiz}");
                }

        }


     
        public class Kara : Tasitlar
        {
            string marka;
            public string Marka { get { return marka; } set { marka = value; } }


            int modelYili;
            public int ModelYili { get { return modelYili; } set { modelYili = value; } }


            int tekerlekSayisi;
            public int TekerlekSayisi { get { return tekerlekSayisi; } set { tekerlekSayisi = value; } }

            public override void Yazdir()
            {
                base.Yazdir();
                Console.WriteLine($"Marka: {this.marka}\nModel Yılı: {this.modelYili}\nTekerlek Sayısı: {this.tekerlekSayisi}\n");
            }
        }

        public class Hava : Tasitlar
        {
            string kullanimAmaci;      //yolcu , yük , eğitim
            public string KullanimAmaci { get { return kullanimAmaci; } set { kullanimAmaci = value; } }


            int irtifa;
            public int Irtifa { get { return irtifa; } set { irtifa = value; } }

            public override void Yazdir()
            {
                base.Yazdir();
                Console.WriteLine($"Kullanım Amacı: {this.kullanimAmaci}\nİrtifa: {this.irtifa}\n");
            }
        }

        public class Deniz : Tasitlar
        {
            string gemiTipi;      //yük , yolcu vs
            public string GemiTipi { get { return gemiTipi; } set { gemiTipi = value; } }


            int uzunluk;
            public int Uzunluk { get { return uzunluk; } set { uzunluk = value; } }

            public override void Yazdir()
            {
                base.Yazdir();
                Console.WriteLine($"Gemi Tipi: {this.gemiTipi}\nUzunluk: {this.uzunluk}\n");
            }
        }

        public class Rayli : Tasitlar
        {
            string tur;      //hızlı tren , geleneksel tren vs
            public string Tur { get { return tur; } set { tur = value; } }


            int vagonSayisi;
            public int VagonSayisi { get { return vagonSayisi; } set { vagonSayisi = value; } }

            public override void Yazdir()
            {
                base.Yazdir();
                Console.WriteLine($"Türü: {this.tur}\nVagon Sayısı: {this.vagonSayisi}\n");
            }
        }


        static void Main(string[] args)
        {
            Kara k1 = new Kara();
            k1.TasitTuru = "KARA/Araba";
            k1.Hiz = 220;
            k1.Marka = "Mercedes";
            k1.ModelYili = 2018;
            k1.TekerlekSayisi = 4;
            k1.Yazdir();


            Kara k2 = new Kara();
            k2.TasitTuru = "KARA/Motosiklet";
            k2.Hiz = 100;
            k2.Marka = "Kawasaki";
            k2.ModelYili = 2020;
            k2.TekerlekSayisi = 2;
            k2.Yazdir();
            Console.WriteLine();


            Deniz d1 = new Deniz();
            d1.TasitTuru = "DENİZ/Gemi";
            d1.Hiz = 30;                        //30 deniz mili 
            d1.GemiTipi = "Yolcu Gemisi";
            d1.Uzunluk = 100;
            d1.Yazdir();

            Deniz d2 = new Deniz();
            d2.TasitTuru = "DENİZ/Gemi";
            d2.Hiz = 30;
            d2.GemiTipi = "Yük Gemisi";
            d2.Uzunluk = 150;
            d2.Yazdir();
            Console.WriteLine();



            Hava h1 = new Hava();
            h1.TasitTuru = "HAVA/Uçak";
            h1.Hiz = 900;
            h1.KullanimAmaci = "Yolcu Uçağı";
            h1.Irtifa = 10500;
            h1.Yazdir();

            Hava h2 = new Hava();
            h2.TasitTuru = "HAVA/Helikopter";
            h2.Hiz = 300;
            h2.KullanimAmaci = "Eğitim Helikopteri";
            h2.Irtifa = 4000;
            h2.Yazdir();
            Console.WriteLine();



            Rayli r1 = new Rayli();
            r1.TasitTuru = "RAYLI/Tren";
            r1.Hiz = 100;
            r1.Tur = "Geleneksel Tren";
            r1.VagonSayisi = 8;
            r1.Yazdir();

            Rayli r2 = new Rayli();
            r2.TasitTuru = "RAYLI/Tren";
            r2.Hiz = 300;
            r2.Tur = "Hızlı Tren";
            r2.VagonSayisi = 6;
            r2.Yazdir();




        }
    }
}
