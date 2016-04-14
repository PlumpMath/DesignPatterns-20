using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SealedSingleton
    {
        private static readonly SealedSingleton instance=new SealedSingleton();
        private SealedSingleton() { }
        
        public static SealedSingleton GetInstance()
        {
            return instance;
        }

    }
}
