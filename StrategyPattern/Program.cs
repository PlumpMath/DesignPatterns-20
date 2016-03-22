using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = string.Empty;
            double money = 0.0;
            Console.WriteLine("请输入打折方式：");
            type = Console.ReadLine();
            CashContext context = new CashContext(type);
            Console.WriteLine("请输入总金额：");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("最后应该收费：" + context.GetResult(money));
            Console.ReadKey();
        }
    }
}
