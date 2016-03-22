using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashReturn : CashSuper
    {
        private double _moneyCodition;
        private double _monyReturn;

        public CashReturn(double moneyCodition, double moneyReturn)
        {
            this._moneyCodition = moneyCodition;
            this._monyReturn = moneyReturn;
        }
        public override double acceptCash(double money)
        {
            if (money >= _moneyCodition)
            {
                return money - _monyReturn;
            }
            else
            {
                return money;
            }
        }
    }
}
