using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Finery : Person
    {

        private Person _component;

        public void Decorate(Person component)
        {
            this._component = component;
        }

        public override void Show()
        {
            if (_component!=null)
            {
                _component.Show();
            }
        }
    }
}
