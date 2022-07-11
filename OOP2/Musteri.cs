using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, o nesneye ait değilmiş gibi duruyorsa o alan orada hata yapıyorsundur.
        //Bir sayısal veride toplama çıkarma gibi şeyler yapmayacaksak onu string olarak vermek veri uyumluluğu açısından işimize yarar.
        //Id ve MusteriNo hem tüzelde hem gerçek kişide mevcut.
        //Musteri classı ebeveyn oluyor. Tüzel ve gerçek  müşteride sadece ona ait olan özellikler yazılır.
    }
}
