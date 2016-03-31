using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject=new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject,"X"));
            subject.Attach(new ConcreteObserver(subject,"Y"));
            subject.Attach(new ConcreteObserver(subject,"Z"));
            subject.SubjectState = "new SubjectState";
            subject.Notify();

            Console.ReadKey();
        }
    }
}
