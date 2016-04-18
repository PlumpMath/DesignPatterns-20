using System;

namespace MediatorPattern
{
    /// <summary>
    /// 具体同事类
    /// </summary>
    public class ConcreteColleageue1:Colleague
    {
        public ConcreteColleageue1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message,this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"同事1得到了消息{message}");
        }
    }
}