using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 抽象的聚集
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
