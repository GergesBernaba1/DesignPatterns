// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using FactoryDesignPattern;
using FactoryDesignPattern.FactoryMethod;
#region Factory
//ICreditCard cardDetails = CreditCardfactory.GetCreditCard("Platinum");

//if (cardDetails != null)
//{
//    Console.WriteLine("CardType : " + cardDetails.GetCardType());
//    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//}
//else
//{
//    Console.Write("Invalid Card Type");
//}
//Console.ReadLine();

#endregion

#region Factory Method 

ICreditCardFacory creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.WriteLine("--------------");
creditCard = new MoneyBackFactoryMethod().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();

#endregion
