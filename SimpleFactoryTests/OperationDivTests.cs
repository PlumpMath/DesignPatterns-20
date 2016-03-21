using Xunit;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Tests
{
    public class OperationDivTests
    {
        [Theory(DisplayName = "对除法的单元测试")]
        [InlineData(1,2,0.5)]
        [InlineData(2,2,1)]
        [InlineData(10,5,2)]
        public void GetResultTest(double numberA, double numberB, double result)
        {
            OperationDiv div=new OperationDiv();
            div.NumberA = numberA;
            div.NumberB = numberB;
            Assert.Equal(div.GetResult(),result);
        }
    }
}