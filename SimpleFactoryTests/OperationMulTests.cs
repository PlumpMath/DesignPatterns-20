using Xunit;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Tests
{
    public class OperationMulTests
    {
        [Theory(DisplayName = "对乘法的单元测试")]
        [InlineData(1.1,1,1.1)]
        [InlineData(0,1000,0)]
        [InlineData(5,4,20)]
        public void GetResultTest(double numberA, double numberB, double result)
        {
            OperationMul mul=new OperationMul();
            mul.NumberA = numberA;
            mul.NumberB = numberB;
            Assert.Equal(mul.GetResult(), result);
        }
    }
}