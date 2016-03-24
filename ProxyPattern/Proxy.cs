using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy:IGiveGift
    {
        private Pursuit _pursuit;

        public Proxy(SchoolGirl gril)
        {
            this._pursuit = new Pursuit(gril);
        }
        public void GiveDolles()
        {
            _pursuit.GiveDolles();
        }

        public void GiveFlowers()
        {
            _pursuit.GiveFlowers();
        }

        public void GiveChocolate()
        {
            _pursuit.GiveChocolate();
        }
    }
}
