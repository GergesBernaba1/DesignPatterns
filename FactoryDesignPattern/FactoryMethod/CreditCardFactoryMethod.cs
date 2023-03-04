using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryMethod
{
    public abstract class CreditCardFactoryMethod
    {
        protected abstract ICreditCardFacory MakeProduct();
        public ICreditCardFacory CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
