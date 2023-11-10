using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trendyol urun1 = new Trendyol();
            urun1.urunAdi = "Kazak";
            urun1.urunRengi = "siyah";
            urun1.urunFiyatı = 120;

            Trendyol urun2 = new Trendyol();
            urun2.urunAdi = "Elbise";
            urun2.urunRengi = "kırmızı";
            urun2.urunFiyatı = 259;

            Trendyol urun3 = new Trendyol();
            urun3.urunAdi = "pantolon";
            urun3.urunRengi = "mavi";
            urun3.urunFiyatı = 379;

            Trendyol[] alisveris = new Trendyol[] {urun1, urun2, urun3};

            foreach (var trendyol in alisveris)
            {

                Console.WriteLine(trendyol.urunAdi + trendyol.urunRengi + trendyol.urunFiyatı);
                
            }

        }
    }


    class Trendyol
    {
        public string urunAdi { get; set; }
        public string urunRengi { get; set; }
        public int urunFiyatı { get; set; }

    }
}
