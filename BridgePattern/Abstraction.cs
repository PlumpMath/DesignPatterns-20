using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Abstraction
    {
        protected Implementor Implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.Implementor = implementor;
        }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
