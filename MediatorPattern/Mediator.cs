using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象中介类
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
