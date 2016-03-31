using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternByEventHandler
{
    public class StockObserver
    {
        private string _name;
        private ISubject _subject;

        public StockObserver(string name, ISubject subject)
        {
            this._subject = subject;
            this._name = name;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭股票 ，继续工作");
        }
    }
}
