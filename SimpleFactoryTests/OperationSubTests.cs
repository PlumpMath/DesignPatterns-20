using Xunit;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Tests
{
    public class OperationSubTests
    {
        [Theory(DisplayName = "对减法的单元测试")]
        [InlineData(1,1,0)]
        [InlineData(1,-1,2)]
        [InlineData(1.1,1.1,0)]
        public void GetResultTest(double numberA, double numberB, double result)
        {
            OperationSub sub=new OperationSub();
            sub.NumberA = numberA;
            sub.NumberB = numberB;
            Assert.Equal(sub.GetResult(),result);
        }
    }
}