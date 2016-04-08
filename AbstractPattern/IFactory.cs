using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public interface IFactory
    {
        IUser CreaUser();
    }
}
