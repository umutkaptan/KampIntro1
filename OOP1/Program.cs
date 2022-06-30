using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Üstteki gibi de ürün tanımlayabiliriz alttaki gibi de şahsen alttaki daha kolay gibi geldi.Direkt süslü parantezin içinde yazdık altta.

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //case sensitive
            //Pascalcase   //camelcase
            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //void kısmı
            productmanager.Topla2(3,6);

            //return kısmı
            int toplamasonucu = productmanager.Topla(3, 6);
            Console.WriteLine(toplamasonucu*2);

        }
    }
}
