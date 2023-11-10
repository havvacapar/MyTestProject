using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {

            // product.ProductName = "Kalem"; 
            // "program"da Console.WriteLine(product1.ProductName);'i çağırdık ve burda product1.in adını kamera yaptık.

            Console.WriteLine(product.ProductName + " "+ "Eklendi.");

        }
        public void Uptade(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

    }
}
