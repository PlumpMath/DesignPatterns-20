using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jingli=new CommonManager("经理");
            Majordomo zongjian=new Majordomo("总监");
            GeneralManager zongjingli=new GeneralManager("总经理");

            jingli.SetSuperior(zongjian);
            zongjian.SetSuperior(zongjingli);

            Request request = new Request
            {
                RequsetType = "请假",
                Number = 1,
                RequsetContent = "小菜请假"
            };
            jingli.RequsetApplication(request);

            Request request1 = new Request
            {
                RequsetType = "请假",
                Number = 5,
                RequsetContent = "小菜请假"
            };
            jingli.RequsetApplication(request1);

            Request request2 = new Request
            {
                RequsetType = "加薪",
                Number = 100,
                RequsetContent = "小菜加薪"
            };
            jingli.RequsetApplication(request2);

            Request request3 = new Request
            {
                RequsetType = "加薪",
                Number = 1000,
                RequsetContent = "小菜加薪"
            };
            jingli.RequsetApplication(request3);

            Console.ReadKey();
        }
    }
}
