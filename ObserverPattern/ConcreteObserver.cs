using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { this._subject = value; }
        }


        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }


        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"观察者{_name}的新状态是{_observerState}");
        }
    }
}
