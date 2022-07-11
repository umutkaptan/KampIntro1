using System;
using System.Collections.Generic;
using System.Text;

//Eğer List olmasaydı onu biz nasıl yazardık onu yapıcaz.

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items;  //Bunu Add li kısıma eklemek için newlememiz gerekiyor.Newleyince sıfır elemanlı bir array oluşturuyoruz.
        //Classı newlediğimiz anda çalışan bloğa constructor bloğu denir. ctor yazıp tab tab yapınca alttaki geldi.Classı newlersen MyList kısmı otomatik çalışıyor.
        public MyList()
        {
            items = new T[0]; 
        }
        public void Add(T item)  //T'ye ne değer verirsek veri tipi o olacak.
        {
              //geçiçi dizi
            T[] tempArray = items;  //newleyince eski elemanlar uçar çünkü yeni referans numarası oluşur.Uçmasınlar diye o referans numarası başkasına tutturulur.Sonra kendine yeni referans numarası alınır.
            items = new T[items.Length + 1];  //Arrayin eleman sayısını 1 arttırdık.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçiçi olarak tempArray'e verdiğimiz değerleri item'sa geri alıyoruz.
            }
            items[items.Length - 1] = item;   //itemsin son elemanı eşittir item yaptık.
        }
    }
}
