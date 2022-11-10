using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    public class TitaniumFactory:CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new TitaniumCard();
            return product;
        }
    }
}
