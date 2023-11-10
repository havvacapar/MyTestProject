using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle (Urun urun) //public vois Ekle() ile başka sayfadan alttaki yazıyı çağırabiliyoz.
                                     //Alttaki yazıyı urunler sepete eklenince yazsın diye Ekle() içine urun classını ekledik.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
        }
    }
}
