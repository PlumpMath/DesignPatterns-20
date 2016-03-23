using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            this._name = name;
        }
        public Person() { }
        public virtual void Show()
        {
            Console.WriteLine($"装扮{_name}");
        }
    }
}
