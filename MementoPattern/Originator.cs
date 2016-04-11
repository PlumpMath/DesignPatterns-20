using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private String _state;

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void SetMmemnto(Memento memento)
        {
            State = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State:"+State);
        }
    }
}
