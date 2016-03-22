using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashRebate : CashSuper
    {
        private double _moneyRebate;

        public CashRebate(double moneyRebate)
        {
            this._moneyRebate = moneyRebate;
        }
        public override double acceptCash(double money)
        {
            return money*_moneyRebate;
        }
    }
}
