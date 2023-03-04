// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using FactoryDesignPattern;

ICreditCard cardDetails = CreditCardfactory.GetCreditCard("Platinum");

if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();


