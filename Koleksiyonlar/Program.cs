using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler1 = new string[] { "Havva", "Enes", "Mehmet", "Ersöz" };
            //Console.WriteLine(isimler1[0]);
            //Console.WriteLine(isimler1[1]);
            //Console.WriteLine(isimler1[2]);
            //Console.WriteLine(isimler1[3]);
            //isimler1[4] = "İlker";
            //Console.WriteLine(isimler1[4]); //Hata verir, ekleme yapmak için üste yazmak lazım
            //Console.WriteLine(isimler1[0]); 
            //4.eleman atamak istersek yukarıda {} içine yazmamız lazım
            //ama bu değerler bir excellden geldiği için ekleme yapamayız
            //o yüzden koleksiyon oluşturmamız lazım.

            List<string> isimler = new List<string> { "Havva", "Enes", "Mehmet", "Ersöz" };
            Console.WriteLine(isimler[0]);
            isimler.Add("Ahmet");//listenin sonuna Ahmet ekler.
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); 
            
            

        }
    }
}
