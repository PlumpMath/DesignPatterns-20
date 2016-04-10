using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : Target
    {
        //private Adaptee adaptee=new Adaptee();
        private Adaptee _adaptee;

        public Adaptee Adaptee
        {
            get
            {
                return _adaptee;
            }

            set
            {
                _adaptee = value;
            }
        }

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public override void Request()
        {
            //base.Request();
            _adaptee.SpecificRequest();
        }
    }
}
