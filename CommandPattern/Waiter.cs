using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Waiter
    {
        //private Command command;

        //public void SetOrder(Command com)
        //{
        //    this.command = com;
        //}

        //public void Notify()
        //{
        //    command.ExcuteCommand();//多态
        //}
        private IList<Command> orders=new List<Command>();

        public void SetOrder(Command com)
        {
            if (com.ToString() == "   ")
            {
                Console.WriteLine("鸡翅没有了");
            }
            else
            {
                orders.Add(com);
                Console.WriteLine($"增加订单{com.ToString()}时间{DateTime.Now.ToString()}");
            }
        }

        public void CancelOrder(Command com)
        {
            orders.Remove(com);
            Console.WriteLine($"取消订单{com.ToString()}时间{DateTime.Now.ToString()}");
        }

        public void Notify()
        {
            foreach (var order in orders)
            {
                order.ExcuteCommand();
            }
        }
    }
}