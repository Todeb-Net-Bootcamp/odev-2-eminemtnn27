using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class CreditCard : TodebCard
    {
        public CreditCard(string username) : base(username)
        {
             //superclass
             //TodebCard sınıfındaki username alanına parametre olarak geçecek
        }
        //
        public override void WriteCardUserName()
        {
            Console.WriteLine($"{BankName} {userName} ");
        }
    }
}
