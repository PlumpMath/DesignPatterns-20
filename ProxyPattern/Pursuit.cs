using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Pursuit:IGiveGift
    {
        private SchoolGirl _schoolGirl;

        public Pursuit(SchoolGirl schoolGirl)
        {
            this._schoolGirl = schoolGirl;
        }
        public void GiveDolles()
        {
            Console.WriteLine(_schoolGirl.Name+"送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_schoolGirl.Name+"送你花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_schoolGirl.Name+"送你巧克力");
        }
    }
}
