using Xunit;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    public class CashNormalTests
    {
        [Theory(DisplayName = "正常收费的单元测试")]
        [InlineData(1)]
        [InlineData(1000.2)]
        public void acceptCashTest(double money)
        {
            CashNormal normal=new CashNormal();
            Assert.Equal(normal.acceptCash(money),money);
        }
    }
}