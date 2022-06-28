using System;
using System.Collections.Generic;
using System.Text;

//manager gibi yazılar görürsek bu dosya operasyonlar içeriyor demektir
namespace Metotlar
{
    class SepetManager
    {
        //naming convention(isimlendirme kuralı)
        //void: Bu ifade değer döndermeden yapılacak fonksiyonel işlemlerin gerçekleştirilmesi için kullanılır.Diğer tarafa sonucu göndermez sonuc ya o class içerisinde kalır ya da ekrana yazdırılabilir.
        //Public anahtar kelimesi, kelime anlamı olarak açık-erişilebilir anlamına gelir. C#'da ise public ile tanımlanan metotlara başka sınıflar içerisinden ulaşılabileceği anlamını çıkarabiliriz. Yani private anahtar kelimesinin tam tersidir.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urunAdi);
        }
    }
}
