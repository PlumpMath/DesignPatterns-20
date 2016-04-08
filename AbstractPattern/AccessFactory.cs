using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class AccessFactory : IFactory
    {
        public IUser CreaUser()
        {
            return new AccessUser();
        }
    }
}
