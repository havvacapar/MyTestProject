using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("dolar azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("dolar artış oku");

            }
            else
            {
                Console.WriteLine("dolar sabit");
            }
    


    //if  (sistemeGirisYapmisMi == true)
    //{
    //Console.WriteLine("kullanıcı ayarlar butonu");
    //}
    //else{
    //Console.WriteLine ("giriş yap");
    //}

    //Console.WriteLine (kategoriEtiketi);

    //}

}
    }
}

