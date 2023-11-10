using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referans örneği
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; 
            sayi2 = 65; 

            Console.WriteLine(sayi1);  // Cevap : 30 int,double,bool...Değer tip


            //Değer Örneği
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayi1);   //Cevap 999 diziler,class,abstract class,inferface...Referans tip

        }
    }
}
