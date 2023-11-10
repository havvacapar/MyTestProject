using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 81;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Phyton";
            kurs2.egitmen = "Berkay Bilgin";
            kurs2.izlenmeOrani = 62;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Kerem Varış";
            kurs3.izlenmeOrani = 95;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar) //bir üst satırdaki 'kurslar' dizisini forech'a tanımladık.

            {
                //Console.WriteLine(kurs.kursAdi);    //Sadece kurs adlarını yazdırmak istersek,
                //Console.WriteLine(kurs.kursAdi + ":" + kurs1.egitmen);    //Sadece kurs1in adı ve izlenme oranını yazdırmak istersek;
                Console.WriteLine(kurslar);
            }

            


        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }

        public string egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}
