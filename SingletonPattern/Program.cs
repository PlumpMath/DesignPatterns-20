using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //错误，不应调用构造函数
            //Singleton s1=new Singleton();
            //Singleton s2=new Singleton();
            //if (s1 == s2)
            //{
            //    Console.WriteLine("两个对象相同");
            //}


            //单线程下
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("两个对象相同");
            }

            //单线程
            SealedSingleton ss1=SealedSingleton.GetInstance();
            SealedSingleton ss2 = SealedSingleton.GetInstance();
            if (ss1 == ss2)
            {
                Console.WriteLine("两个对象相同");
            }

            Console.ReadKey();
        }
    }
}
