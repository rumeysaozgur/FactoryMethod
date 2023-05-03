using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_odev
{
    public abstract class MerkezFabrika
    {
        public abstract IFactory TelefonAlmak(string type);
    }
}
