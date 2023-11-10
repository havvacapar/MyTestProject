using Metotlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 10;   

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 2;

            Urun[] urunler = new Urun[] {urun1, urun2}; //Urun classında yer alan tanımlamalar için array oluşturduk.Array adını urunler koyduk.

            foreach (var uruns in urunler) //Var veri tipini koddan otomatik buluyor. İstersen direkt 'Urun' de yazabilirsin 
                                              // foreach dongusune uruns adını verdim. ve 'Urunler' dizisini döndürmesini istedim.

            {
                Console.WriteLine(uruns.Adi); //Dongu adını yazıp(uruns) dongunun içinden hangi tanımlamaları yazdırmasını istersek(adi) onu yazıyoz.
                Console.WriteLine(uruns.Fiyati);
                Console.WriteLine(uruns.Aciklama);
                Console.WriteLine(uruns.stokAdedi);
                Console.WriteLine("------------");

            }

            Console.WriteLine("--------Metotlar--------");

            SepetManager sepet = new SepetManager(); //bunu yazmadan önce sepetmanager sayfasına gidip, ürün sepete eklenince çıkmasını istediğimiz yazıyı yazdık.
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

        }
    }
}