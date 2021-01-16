using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();

            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;
            kurs2.KursAdi = "Java";

            Kurs kurs3 = new Kurs();

            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;
            kurs3.KursAdi = "Python";

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

        }
        
    }

    class Kurs
    {
        //prob
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }


    }




}
