using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{//AMACIMIZ KENDİ LIST fonksiyonumuzu yazmak.
    class MyList<T> //T'yi biz kafadan verdik. Veri tipi gibi oldu
    {
        T[] elemanlar;
        //constructor -cont yazıyoruz //bir class newledniğinde çalışan bloğa constructor deniyor.
        public MyList()
        {
            elemanlar = new T[0]; //artık 0 elemanlı bir dizi oluşturduk
        }
        public void Add(T eleman) //programda listi string tanımladığımız için T burda string oldu.
        {
            T[] tempArray = elemanlar; //diziyi newleyince elemanlar kaybolmasın diye emanet ediyoruz.
            elemanlar = new T[elemanlar.Length + 1];  //newlenen elemanlar dizisinin içi silindi ama Add her çalıştığında diziye bir eleman eklencek
            for (int i = 0; i < tempArray.Length; i++)
            {
                elemanlar[i] = tempArray[i];   //elemanlar kaybolan içeriğini geri aldı. Ama eklenen son eleman boş.
            }

            elemanlar[elemanlar.Length - 1] = eleman;  //oluşan son boş yere gönderilen T tipindeki elamanı yazdırdık.
        }

    }
}
