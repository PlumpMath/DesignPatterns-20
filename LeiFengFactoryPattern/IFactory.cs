using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiFengFactoryPattern
{
    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
}
