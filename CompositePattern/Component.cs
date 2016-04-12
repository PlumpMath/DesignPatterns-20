﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Component
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Component(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);

        public abstract void Display(int depth);


    }
}
