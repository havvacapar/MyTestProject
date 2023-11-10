using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "a kursu";
            string kurs2 = "b kursu";
            string kurs3 = "c kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            // yukarıdaki gibi tek tek yazmak yerine 'Array' ile toplu yazdık.

            //Array - Diziler

            // string[] kurslar = new string[] {"a kursu", "b kursu", "c kursu", "d kursu" };




            // for (int i = 1; i < kurslar.Length; i=i+2)
            // {
            //     Console.WriteLine(kurslar[i]);
            // }
            // Console.WriteLine("Sayfa Sonu-Footer");


            //FOREACH *FOR İNT İLE AYNI


            string[] kurslar = new string[] { "a kursu", "b kursu", "c kursu", "d kursu" };

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu-Footer");

        }
    }
}








