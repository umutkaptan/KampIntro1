using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //değer tutucu-alias
            //int tam sayılar içindir
            //double ondalıklı sayılar içindir
            //bool boolean cinsindeki verileri tutar onlarda true ve falsedir
            
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            
            else 
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
           
            
        }
    }
}
