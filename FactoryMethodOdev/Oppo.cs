using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_odev
{
    public class Oppo : IFactory
    {
        public void Telefon(int fiyat)
        {
            Console.WriteLine($"Oppo markası olan telefonun fiyatı: {fiyat}");
        }
    }
}
