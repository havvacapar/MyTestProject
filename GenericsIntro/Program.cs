using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Mylist classındaki T'yi string olarak tanımladık.
                                                           //int olarak da istersek tanımlarız
            isimler.Add("HAvva");
            Console.WriteLine(isimler);
        }
    }
}
