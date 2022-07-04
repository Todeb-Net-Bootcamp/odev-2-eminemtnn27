using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{    
    //bir abstract class oluşturuldu
    public abstract class TodebCard
    {        
        protected string userName { get; set; } //encapsulation(kapsülleme)
       
        //constructor(kurucu metot)
        public TodebCard(string username)
        {
            userName = username;
        }
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string BankName { get; set; }
        public virtual void WriteCardUserName()
        {
            Console.WriteLine(userName);
        }
    }
}
 