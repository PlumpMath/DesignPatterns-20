using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternByEventHandler
{
    public class Boss : ISubject
    {
        //public delegate void EventHandler();
        public event EventHandler Update;
        private string action;
        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }
    }
}
