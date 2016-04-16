using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract  class Command
    {
        protected Barbecuer Receiver;

        protected Command(Barbecuer receiver)
        {
            this.Receiver = receiver;
        }

        abstract public void ExcuteCommand();
    }
}
