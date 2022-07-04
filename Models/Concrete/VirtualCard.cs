using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class VirtualCard : TodebCard
    {
        public VirtualCard(string username) : base(username)
        {
             
        }
        public override void WriteCardUserName()
        {
            Console.WriteLine($"{userName} ");
        }
    }
}
