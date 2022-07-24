using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi." );
        }
        
        
        
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}
    }
}



//return'de ise işlem sonucunu yeni bir değişkene atayıp onu sonradan kullanmaya devam edebiliriz.
//void=Git,yap,bitir ve onu devamında kullanamazsın.Örneğin toplam2 de sonucu 9 bulursun ama o değeri sonra kullanamazsın.
//update=güncellemek
//add=ekleme