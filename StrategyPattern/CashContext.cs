using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashContext
    {
        private CashSuper _cashSuper;

        //public CashContext(CashSuper cash)
        //{
        //    this._cashSuper = cash;//构造函数注入
        //}


        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    _cashSuper=new CashNormal();
                    break;
                case "满300返299":
                    _cashSuper=new CashReturn(300,299);
                    break;
                case "八折":
                    _cashSuper=new CashRebate(0.8);
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cashSuper.acceptCash(money);
        }
    }
}
