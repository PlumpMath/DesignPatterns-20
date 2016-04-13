using System.Collections.Generic;

namespace IteratorPattern
{
    /// <summary>
    /// 具体的聚集
    /// </summary>
    public class ConcreateAggregate : Aggregate
    {
        /// <summary>
        /// 被迭代的集合
        /// </summary>
        private IList<object> items = new List<object>();

        /// <summary>
        /// 集合的元素个数
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        /// <summary>
        /// 返回特定的迭代器
        /// </summary>
        /// <returns></returns>
        public override Iterator CreateIterator()
        {
            return new ConcreateIterator(this);
        }
    }
}