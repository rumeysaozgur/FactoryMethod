using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_odev
{
    public class Iphone : IFactory
    {
        public void Telefon(int fiyat)
        {
            Console.WriteLine($"Iphone markası olan telefonun fiyatı: {fiyat}");
        }
    }
}
