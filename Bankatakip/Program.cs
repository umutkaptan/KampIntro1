using System;

namespace Bankatakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Umut Kaptan";
            musteri1.TcKimlikNo = 572294;
            musteri1.Yasi = 25;
            musteri1.Cinsiyeti = "Erkek";
            musteri1.FaizOrani = 0.85;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Merve Loraslı";
            musteri2.TcKimlikNo = 721842;
            musteri2.Yasi = 23;
            musteri2.Cinsiyeti = "Kadın";
            musteri2.FaizOrani = 0.64;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Şevval Erol ";
            musteri3.TcKimlikNo = 154796;
            musteri3.Yasi = 20;
            musteri3.Cinsiyeti = "Kadın";
            musteri3.FaizOrani = 1.05;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi+" "+musteri.TcKimlikNo+" "+musteri.Yasi+" "+musteri.Cinsiyeti+" "+musteri.FaizOrani);
            }
            Console.WriteLine("..........");

            MusteriManager musteriyonetici = new MusteriManager();
            musteriyonetici.Silme(musteri1);
            musteriyonetici.Ekleme(musteri2);
            musteriyonetici.Listeleme(musteri3);

        }

        }
}
