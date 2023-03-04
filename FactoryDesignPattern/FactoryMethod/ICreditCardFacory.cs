using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface ICreditCardFacory
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class Platinum : ICreditCardFacory
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
    public class Titanium : ICreditCardFacory
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
    public class MoneyBackFactoryMetod: ICreditCardFacory
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        { 
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }

}
