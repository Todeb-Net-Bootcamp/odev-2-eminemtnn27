using Models.Abstract;
using Models.Concrete;
using System;

namespace TodebProject2
{
    //soyut sınıflar için abstract klasörü,gerçek sınıflar(kalıtım alan) için concrete klasörü kullanıldı
    class Program
    {
        static void Main(string[] args)
        {
            //TodebCard türünde ismi "Card" olan bir creditcard nesnesi
            var creditCard = new CreditCard("Emine Metin");
            creditCard.BankName = "Akbank";
            creditCard.CardNumber = Guid.NewGuid().ToString();
            creditCard.WriteCardUserName();

            var creditCard2 = new CreditCard("Derya Yurt");
            creditCard2.BankName = "Finansbank";
            creditCard2.CardNumber = Guid.NewGuid().ToString();
            creditCard2.WriteCardUserName();

            TodebCard card = new CreditCard("test");
            //her tödeb kartı bir kredi kartı değildir,fakat her kredi kartı bir tödeb kartıdır

            var virtualCard = new VirtualCard("Emine Metin Sanal");
            virtualCard.BankName = "Akbank";
            virtualCard.CardNumber = Guid.NewGuid().ToString();
            virtualCard.WriteCardUserName();

            var virtualCard2 = new VirtualCard("Derya Yurt Sanal");
            virtualCard2.BankName = "Ziraatbank";
            virtualCard2.CardNumber = Guid.NewGuid().ToString();
            virtualCard2.WriteCardUserName();

            TodebCard card2 = new VirtualCard("Sanal test");
            //abstract sınıflar "new" lenemez
        }
    }
}
