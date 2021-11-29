using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Xunit; 

namespace CalcUnitTest
{
    public class BusinessLogicUnitTest
    {
        [Theory]
        [InlineData(new bool[] { true, true, true, true })]
        [InlineData(new bool[] { false, true, true, true })]
        public void OperationStateCheckerTest(bool[] operation)
        {
            Arithmetic test1 = new Arithmetic();
            test1.pluswasclicked = operation[0];
            test1.minuswasclicked = operation[1];
            test1.multiplywasclicked = operation[2];
            test1.dividewasclicked = operation[3];
            Assert.True(test1.operationStatechecker());
        }

        [Theory]
        [InlineData(3, 0, true)]
        [InlineData(3, 3, false)]
        [InlineData(0, 0, false)]
        [InlineData(0, 0, true)]
        [InlineData(0, 3, true)]
        public void EnableOperationFalseTest(decimal first, decimal second, bool operation)
        {
            Arithmetic test1 = new Arithmetic();
            test1.first = first;
            test1.second = second;
            Assert.False(test1.enableOperation(operation));
        }
        [Fact]
        public void EnableOperationTrueTest()
        {
            Arithmetic test1 = new Arithmetic();
            test1.first = 3;
            test1.second = 0;
            Assert.True(test1.enableOperation(false));
        }
    }
}
