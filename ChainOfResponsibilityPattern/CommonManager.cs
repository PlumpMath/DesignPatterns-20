using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequsetApplication(Request request)
        {
            if (request.RequsetType == "请假" && request.Number <= 2)
            {
                Console.WriteLine($"{name}:{request.RequsetContent}数量{request.Number}被批准");
            }
            else
            {
                //if (superior != null)
                //{
                //    superior.RequsetApplication(request);
                //}
                superior?.RequsetApplication(request);
            }
        }
    }
}
