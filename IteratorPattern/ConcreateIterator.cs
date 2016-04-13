using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 具体的迭代器
    /// </summary>
    class ConcreateIterator:Iterator
    {
        private ConcreateAggregate _aggregate;
        private int current = 0;

        /// <summary>
        /// 初始化迭代器
        /// </summary>
        /// <param name="aggregate">需要被迭代的具体集合</param>
        public ConcreateIterator(ConcreateAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            //object ret = null;
            current++;
            if (current < _aggregate.Count)
            {
                return _aggregate[current];
            }
            else
            {
                return null;
            }
            //return ret;
        }

        public override bool IsDone()
        {
            return current >= _aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return _aggregate[current];
        }
    }
}
