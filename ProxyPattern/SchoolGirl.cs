using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class SchoolGirl
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
    }
}
