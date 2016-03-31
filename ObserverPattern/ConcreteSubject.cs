using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return this._subjectState; }
            set { this._subjectState = value; }
        }
    }
}
