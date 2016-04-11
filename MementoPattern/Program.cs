using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator=new Originator();
            originator.State = "OK";
            originator.Show();

            Caretaker caretaker=new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "NOT OK";
            originator.Show();

            originator.SetMmemnto(caretaker.Memento);
            originator.Show();

            Console.ReadKey();
        }
    }
}
