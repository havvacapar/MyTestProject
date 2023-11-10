using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
       
        {

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(3, 5);
            dortIslem.Topla(5,9);

        }
    }
}
