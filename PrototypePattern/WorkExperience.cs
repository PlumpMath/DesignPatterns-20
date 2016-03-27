using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class WorkExperience : ICloneable
    {
        private string _workDate;

        public string WorkDate
        {
            get { return _workDate; }
            set { this._workDate = value; }
        }

        private string _company;

        public string Company
        {
            get { return _company; }
            set { this._company = value; }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
