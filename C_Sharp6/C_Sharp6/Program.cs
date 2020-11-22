using System;

namespace C_Sharp6
{

    public class Tasit
    {
        private string marka;

        public string Marka
        { 
            get { return marka; }

            set { marka = value; }
        }
        private int hiz;
        public int Hiz { 
            get 
            { 
                return hiz;
            } 
            set 
            { 
                hiz = value; 
            } 
        }

        public virtual void TasitYazdir()
        {
            Console.WriteLine($"MARKASI: {this.marka}\nHIZI: {this.hiz}");
            Console.WriteLine();
        }
    }




    public class Araba : Tasit            //INHERITANCE
    {
        public string vites;

        public override void TasitYazdir()
        {
            base.TasitYazdir();
            Console.WriteLine($"VİTES: {this.vites}\n");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Tasit tasit1 = new Tasit();
            tasit1.Marka = "ABC";
            tasit1.Hiz = 50;
            tasit1.TasitYazdir();


            Araba araba1 = new Araba();
            araba1.Marka = "MERCEDES";
            araba1.Hiz = 220;
            araba1.vites = "OTOMATİK";
            araba1.TasitYazdir();
            
        }
    }
}
