using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 具体中介类
    /// </summary>
   public class ConcreteMediator:Mediator
   {
       private ConcreteColleageue1 colleageue1;
       private ConcreteColleageue2 colleageue2;

       public ConcreteColleageue1 Colleageue1
       {
           set { colleageue1 = value; }
       }

       public ConcreteColleageue2 Colleageue2
       {
            set { colleageue2 = value; }
       }



       public override void Send(string message, Colleague colleague)
       {
           if (colleageue1 == colleague)
           {
               colleageue2.Notify(message);
           }
           else
           {
               colleageue1.Notify(message);
           }
       }
    }
}
