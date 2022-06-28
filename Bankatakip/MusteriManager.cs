using System;
using System.Collections.Generic;
using System.Text;

namespace Bankatakip
{
    class MusteriManager
    {
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Tebrikler kullanıcı sistemden kaldırıldı"+" :" +musteri.MusteriAdi);
        }
        
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Tebrikler müşteri başarıyla eklendi"+ " :"+ musteri.MusteriAdi);
        }
        
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri listelendi" + " :" + musteri.MusteriAdi+musteri.Yasi);
        }
    }
}
