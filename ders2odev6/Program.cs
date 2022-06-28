using System;

namespace ders2odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Kitap";
            urun1.Sayisi = 25;
            urun1.VarmiYokmu = true;
            urun1.Fiyati = 15.85;

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Kalem";
            urun2.Sayisi = 20;
            urun2.VarmiYokmu = false;
            urun2.Fiyati = 3.45;

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Silgi";
            urun3.Sayisi = 50;
            urun3.VarmiYokmu = true;
            urun3.Fiyati = 2.07;

            Urunler[] merhaba = new Urunler[] { urun1, urun2, urun3 };

            foreach (var naber in merhaba)
            {
                Console.WriteLine(naber.UrunAdi+" "+naber.Sayisi+" "+naber.VarmiYokmu+" "+naber.Fiyati);
            }
        }
    }


    class Urunler
    {
        public string UrunAdi { get; set; }
        public int Sayisi { get; set; }
        public bool VarmiYokmu { get; set; }
        public double Fiyati { get; set; }

    }
}
