using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Operation
    {
        private double _numberA;

        public double NumberA
        {
            get { return _numberA; }
            set
            {
                try
                {
                    _numberA = Convert.ToDouble(value);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private double _numberB;

        public double NumberB
        {
            get { return _numberB; }
            set
            {
                try
                {
                    _numberB = Convert.ToDouble(value);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public virtual double GetResult()
        {
            double result = 0.0;
            return result;
        }
    }
}
