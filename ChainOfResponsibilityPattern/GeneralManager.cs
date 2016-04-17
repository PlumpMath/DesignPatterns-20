using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequsetApplication(Request request)
        {
            if (request.RequsetType == "请假")
            {
                Console.WriteLine($"{name}:{request.RequsetContent}数量{request.Number}被批准");
            }else if (request.RequsetType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine($"{name}:{request.RequsetContent}数量{request.Number}被批准");
            }
            else
            {
                Console.WriteLine($"{name}:{request.RequsetContent}数量{request.Number}再说吧");
            }
        }
    }
}
