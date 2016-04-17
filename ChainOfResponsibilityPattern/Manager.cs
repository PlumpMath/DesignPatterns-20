using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Manager
    {
        protected string name;
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager manager)
        {
            this.superior = manager;
        }

        abstract public void RequsetApplication(Request request);
    }
}
