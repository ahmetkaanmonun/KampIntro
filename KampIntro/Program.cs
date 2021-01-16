using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool girisYapmisMi = true;

            if (girisYapmisMi == true){

                Console.WriteLine("Giriş yapılmış");

            }
            else
            {

                Console.WriteLine("Giriş yapılmamış");

            }
        }
    }
}
