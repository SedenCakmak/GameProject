using System;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Ankastre Set";
            int fiyati = 2449;
            int Id = 123456789;
            string ozellik = "Cam Yüzey";
            string kategori = "Beyaz Eşya";
            string marka = "Vestel";
            string renk = "Kristal Beyaz";


            Product urun1 = new Product();
            urun1.Adi = "Ankastre Set";
            urun1.Fiyati = 2449;
            urun1.Id = 123456789;
            urun1.Ozellik = "Cam Yüzey";
            urun1.Kategori = "Beyaz Eşya";
            urun1.Marka = "Vestel";
            urun1.Renk = "Kristal Beyaz";

            Product urun2 = new Product();
            urun2.Adi = "NFK A++ Kombi No Frost Buzdolabı";
            urun2.Fiyati = 2799;
            urun2.Id = 985647;
            urun2.Ozellik = "No Frost";
            urun2.Kategori = "Buzdolabı";
            urun2.Marka = "Regal";
            urun2.Renk = "Beyaz";

            Product urun3 = new Product();
            urun3.Adi = "A+++ 14000 Devir 9 kg Çamaşır Makinesi";
            urun3.Fiyati = 3499;
            urun3.Id = 15975346;
            urun3.Ozellik = "Resmi Distribütör Garantili";
            urun3.Kategori = "Çamaşır Makinesi";
            urun3.Marka = "Samsung";
            urun3.Renk = "Beyaz";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Ozellik);
                Console.WriteLine(urun.Kategori);
                Console.WriteLine(urun.Marka);
                Console.WriteLine(urun.Renk);
                Console.WriteLine("------------");

            }
            Console.WriteLine("foreach bitti.");

            

            


        }
    }
}
