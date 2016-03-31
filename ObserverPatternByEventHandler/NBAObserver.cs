using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternByEventHandler
{
    public class NBAObserver
    {
        private string _name;
        private ISubject _subject;

        public NBAObserver(string name, ISubject subject)
        {
            this._subject = subject;
            this._name = name;
        }

        public void CloseNBA()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭NBA，继续工作");
        }
    }
}
