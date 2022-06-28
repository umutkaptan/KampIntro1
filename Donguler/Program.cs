using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-diziler
            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs","Java","Python" };
            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("For bitti");

            //foreach dizi temelli yapıları tek tek dönmeye yarıyor.foreachla dolaşmak daha kolay.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);  //kurs aliasdır a,b,c de denebilir fark yapmaz.
            }

            Console.WriteLine("Sayfa sonu");



        }
    }
}
