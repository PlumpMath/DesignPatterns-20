using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPatternWithReflection
{
    public interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
