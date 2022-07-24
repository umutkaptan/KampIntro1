﻿using System;


//Inherıtance konusu

namespace OOP2
{
    class Program
    {
        //Soyutlama mantığını kavramaya çalışacağız.
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "2174824";
            
            


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Ebeveyn olan classımız alt classların referans kodlarını tutabilir.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
