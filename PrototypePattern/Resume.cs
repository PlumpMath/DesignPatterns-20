using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Resume:ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperience _workExperience;

        public Resume(string name)
        {
            this._name = name;
            _workExperience=new WorkExperience();
        }

        private Resume(WorkExperience workExperience)
        {
            this._workExperience = (WorkExperience)workExperience.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this._age = age;
            this._sex = sex;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            _workExperience.Company = company;
            _workExperience.WorkDate = workDate;
        }

        public void Display()
        {
            Console.WriteLine(_name+_age+_sex);
            Console.WriteLine($"工作经历:{this._workExperience.Company+this._workExperience.WorkDate}");
        }
        public object Clone()
        {
            Resume obj=new Resume(this._workExperience);
            obj._age = this._age;
            obj._name = this._name;
            obj._sex = this._sex;
            return obj;
        }
    }
}
