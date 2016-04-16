using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boyBarbecuer=new Barbecuer();
            Command bakeMutton=new BakeMuttonCommand(boyBarbecuer);
            Command bakeChicken=new BakeChickenWingCommand(boyBarbecuer);
            Command bakeMutton1 = new BakeMuttonCommand(boyBarbecuer);
            Command bakeChicken1 = new BakeChickenWingCommand(boyBarbecuer);

            Waiter girl=new Waiter();
            girl.SetOrder(bakeChicken);
            girl.SetOrder(bakeMutton);
            girl.SetOrder(bakeChicken1);
            girl.SetOrder(bakeMutton1);

            girl.Notify();

            girl.CancelOrder(bakeChicken1);
            Console.ReadKey();
        }
    }
}
