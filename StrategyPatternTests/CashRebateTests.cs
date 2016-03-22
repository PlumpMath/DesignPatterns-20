using Xunit;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    public class CashRebateTests
    {
        [Theory(DisplayName = "打折测试")]
        [InlineData(0.8,1000)]
        [InlineData(0.56,10000)]
        public void acceptCashTest(double rebate,double money)
        {
            CashRebate cashRebate=new CashRebate(rebate);
            Assert.Equal(cashRebate.acceptCash(money),rebate*money);
        }
    }
}