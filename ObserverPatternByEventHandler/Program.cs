using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternByEventHandler
{
    public delegate void EventHandler();
    class Program
    {
        static void Main(string[] args)
        {
            Boss b=new Boss();

            StockObserver one=new StockObserver("张三",b);
            StockObserver two=new StockObserver("李四",b);
            NBAObserver three=new NBAObserver("王五",b);

            b.Update+=new EventHandler(one.CloseStockMarket);
            b.Update+=new EventHandler(two.CloseStockMarket);
            b.Update+=new EventHandler(three.CloseNBA);


            b.SubjectState = "老板回来了";
            b.Notify();

            Console.ReadKey();
        }
    }
}
