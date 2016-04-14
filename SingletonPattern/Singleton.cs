using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static readonly object syncRoot=new object();
        private static Singleton _instance=null;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public static Singleton GetInstance()
        {
            //不行
            //if (_instance != null)
            //{
            //    return _instance;
            //}
            //else
            //{
            //    return new Singleton();
            //}


            //不行
            //return Instance ?? new Singleton();


            //可以

            //if (_instance != null)
            //{
            //    return _instance;
            //}
            //else
            //{
            //    _instance= new Singleton();
            //    return _instance;
            //}




            //可以
            //if (Instance == null)
            //{
            //    Instance = new Singleton();
            //}
            //return Instance;


            //可以
            //return Instance ?? (Instance = new Singleton());//要赋值才可以




            //多线程加锁

            //if (Instance == null)
            //{
            //    lock (syncRoot)
            //    {
            //        if (Instance == null)
            //        {
            //            Instance=new Singleton();
            //        }
            //    }
            //}
            //return Instance;


            if (Instance != null) return Instance;
            lock (syncRoot)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
            }
            return Instance;

        }
    }
}
