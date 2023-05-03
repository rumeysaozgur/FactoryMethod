using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MerkezFabrika factory = new MersinTelefonFabrikasi();

            IFactory oppo1 = factory.TelefonAlmak("oppo");

            IFactory iphone1 = factory.TelefonAlmak("iphone");

            IFactory huawei1 = factory.TelefonAlmak("huawei");

            oppo1.Telefon(8000);
            huawei1.Telefon(10000);
            iphone1.Telefon(30000);


            Console.Read();
        }
    }
}
