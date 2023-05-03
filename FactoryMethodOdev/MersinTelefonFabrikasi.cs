using FactoryMethod_odev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MersinTelefonFabrikasi : MerkezFabrika
    {
        public override IFactory TelefonAlmak(string type)
        {
          switch(type)
            {
                case "Oppo":
                case "oppo":
                    return new Oppo();
                    

                case "Iphone":
                case "iphone":
                    return new Iphone();
                    

                case "Huawei":
                case "huawei":
                    return new Huawei();
                    
                default:return null;

            }
        }
    }
}
