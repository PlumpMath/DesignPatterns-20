using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper = string.Empty;
            Operation operation=new Operation();
            Console.Title = "简单工厂模式";
            Console.WriteLine("加减乘除：+-*/");
            Console.WriteLine("请输入运算法则：");
            oper = Console.ReadKey().KeyChar.ToString();
            operation = OperationFactory.CreateOperation(oper);
            Console.WriteLine("\n请输入第一个数字：");
            operation.NumberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            operation.NumberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("最后的结果是" + operation.GetResult()+"按任意键结束");
            Console.ReadKey();
        }
    }
}
