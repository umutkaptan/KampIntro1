using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }
    //Eğer interfacei base sınıf olarak kullanıyorsak kullandığımız yerlerde base sınıftaki fonksiyonların kesin olarak olması lazım.
    //Okunurluğu arttırmak için interface sınıflar I harfi iile başlatılır ve interface olduğu anlaşılır.
    //Hesapla ve BiseyYap bankadaki her kredide olması gereken metotlardır, zorunlu yaptık.İnterface aslında bir şablondur kullandığımız yerlerde şablona uymak zorundayız.
}
