using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryMethod
{
    public class MoneyBackFactoryMethod :CreditCardFactoryMethod
    {
        protected override ICreditCardFacory MakeProduct()
        {
            ICreditCardFacory product = new MoneyBackFactoryMetod();
            return product;
        }
    }

    public class PlatinumFactory : CreditCardFactoryMethod
    {
        protected override ICreditCardFacory MakeProduct()
        {
            ICreditCardFacory product = new Platinum();
            return product;
        }
    }
    public class TitaniumFactory : CreditCardFactoryMethod
    {
        protected override ICreditCardFacory MakeProduct()
        {
            ICreditCardFacory product = new Titanium();
            return product;
        }
    }
}
