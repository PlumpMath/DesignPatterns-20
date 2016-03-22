using Xunit;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    public class CashReturnTests
    {
        [Theory(DisplayName = "满返测试(满足条件)")]
        [InlineData(300, 299, 300)]
        [InlineData(200, 150, 260.6)]
        [InlineData(199, 50, 235.59)]
        public void acceptCashTest(double moneyCodition, double moneyReturn, double totalMoney)
        {
            CashReturn cashReturn = new CashReturn(moneyCodition, moneyReturn);
            Assert.Equal(cashReturn.acceptCash(totalMoney), totalMoney - moneyReturn);
        }

        

        [Theory(DisplayName = "满返测试(不满足条件)")]
        [InlineData(300, 299, 185)]
        [InlineData(200, 150, 100)]
        [InlineData(199, 50, 23.59)]
        public void acceptCashTestNone(double moneyCodition, double moneyReturn, double totalMoney)
        {
            CashReturn cashReturn = new CashReturn(moneyCodition, moneyReturn);
            Assert.Equal(cashReturn.acceptCash(totalMoney),totalMoney);
        }
    }
}