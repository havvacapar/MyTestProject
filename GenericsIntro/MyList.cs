using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> //Mylistimde T(Type'den geliyor) ile çalışcam anlamına geliyor.
                             //başka bir harf veya isimde yazabiliriz.Genelde T ile gösterilir.
    {
        T[] items; // T tipinde items adında array oluşturduk. Tyi program.csde str olarak tanımladık.T artık string

        public MyList()
        {
                items = new T[0];   //Tyi 0 elemanlı array olarak tanımladık.Bir array olşturduğumuzda onu newle tanımlamak zorundayız.
        }


        public void Add(T item)//T ye hangi veri tipini verirsek ona göre işlem yap.
                               //Tek veri tipine bağlı kalmamış olduk
        {
            T[] tempArray = items; // iteme atadıklarımız uçmasın diye
                                   // tempArraye(GeçiciDizi) sabitledik. newlw kod yazarsak üsttekileri kod görmüyor, görsün diye sabitledik.
            items = new T[items.Length+1] ; //Başlangıçta arrayı 0 elemanlı olarak tanımaldık.Burda eleman ekledikte eleman sayısı kadar arrayi otomatik tanımlaması için bu kodu yazdık.
            for (int i = 0; i < tempArray.Length; i++) //tempArray eleman sayısından bir eksiğine kadar 1er 1er art.
            {
                items[i] = tempArray[i];   //geçici olarak tempe items değerlerini tutma göre vermiştik, o görevi geri aldık. Elemanları itemse geri atadık

            }

            items[items.Length-1] = item;//items 6 elemanlı ise, 1.elmanı 0 kabul ettiği için -1 dedik


        }
    }
        
        
}
