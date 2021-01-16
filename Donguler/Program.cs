using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops

            //Array Definition
            string[] kurslar = new string[] {"Temel Programlamaya Giriş", "Programlamaya başlangıç temel kurs", "Java"};

            for (int i = 0; i < kurslar.Length ; i++)
            {
                
                Console.WriteLine(kurslar[i]);


            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
