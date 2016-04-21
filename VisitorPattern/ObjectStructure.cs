using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element e)
        {
            elements.Add(e);
        }

        public void Detach(Element e)
        {
            elements.Remove(e);
        }

        public void Accept(Visitor v)
        {
            foreach (var item in elements)
            {
                item.Accept(v);
            }
        }
    }
}
