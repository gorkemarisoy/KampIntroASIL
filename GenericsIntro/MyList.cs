using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GenericsIntro
{//AMACIMIZ KENDİ LIST fonksiyonumuzu yazmak.
    class MyList<T> //T'yi biz kafadan verdik. Veri tipi gibi oldu
    {
        T[] items;
        //constructor -cont yazıyoruz //bir class newledniğinde çalışan bloğa constructor deniyor.
        public MyList()
        {
            items = new T[0]; //artık 0 elemanlı T tipinden oluşan bir dizi(array) oluşturduk
                                    //Yani Mylist'i newlediğimiz zaman bu çalışacak
        }
        public void Add(T item) //programda listi string tanımladığımız için T burda string oldu. Add diye de bir metot oluşturduk.
        {
            T[] tempArray = items; //diziyi newleyince elemanlar kaybolmasın diye emanet ediyoruz.
            items = new T[items.Length + 1];  //newlenen elemanlar dizisinin içi silindi ama Add her çalıştığında diziye bir eleman eklencek
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];   //elemanlar kaybolan içeriğini geri aldı. Ama eklenen son eleman boş.
            }

            items[items.Length - 1] = item;  //oluşan son boş yere gönderilen T tipindeki elamanı yazdırdık.
        }

        public int Count
        {
            get { return items.Length; }
        }

       

        
    }
}
