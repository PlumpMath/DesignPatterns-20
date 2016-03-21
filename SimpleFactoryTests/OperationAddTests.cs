using Xunit;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace SimpleFactory.Tests
{
    public class OperationAddTests
    {
        [Theory(DisplayName = "对加法的单元测试")]
        [InlineData(1,1,2)]
        [InlineData(1.1,1.1,2.2)]
        [InlineData(1,-1,0)]
        public void GetResultTest(double numberA,double numberB,double result)
        {
            OperationAdd add=new OperationAdd();
            add.NumberA = numberA;
            add.NumberB = numberB;
            //var add = new Mock<OperationAdd>();
            //add.Setup(a => a.NumberA).Returns(numberA);
            //add.Setup(a => a.NumberB).Returns(numberB);
            
            Assert.Equal(add.GetResult(),result);
        }
    }
}