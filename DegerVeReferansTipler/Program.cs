using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999

            //int,decimal,float,double,bool= Değer tip(sayi1'in değerini sayi2'ye eşitler ve işi biter.sayi2 ile herhangi bir bağlantısı kalmaz) Stack bellekte çalışır.
            //array,class,interface= Referans tip(new demek bellekten(heap'de) bir adres oluştur demektir.Referans tiplerde adresi atarsın eşitleyince.

        }
    }
}
