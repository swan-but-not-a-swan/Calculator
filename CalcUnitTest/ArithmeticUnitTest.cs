using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Xunit;

namespace CalcUnitTest
{
    public class ArithmeticUnitTest
    {
        [Theory]
        [InlineData(3, 4,new bool[] {true, false, false, false}, 7)]
        [InlineData(3, 4, new bool[]{true, true, false, false}, 7)]
        [InlineData(20, 12, new bool[] { false, true, false, false }, 8)]
        [InlineData(20, 12, new bool[] { false, true, false, true }, 8)]
        [InlineData(12.9, 1.5, new bool[] { false, false, true, false }, 19.35)]
        [InlineData(12.9, 0, new bool[] { true, false, false, true }, 12.9)]
        [InlineData(12.9, 0, new bool[] { false, false, false, true }, 0)]
        public void OptionTest(decimal first,decimal second, bool[]operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.pluswasclicked = operation[0];
            test1.minuswasclicked = operation[1];
            test1.multiplywasclicked = operation[2];
            test1.dividewasclicked = operation[3];
            test1.first = first;
            test1.second = second;
            string actual = test1.Options();
            Assert.Equal(expected.ToString(), actual);
        }
        [Theory]
        [InlineData(0, 0, new bool[] { false, false, false, false }, 0)]
        [InlineData(550, 0, new bool[] { false, false, false, false }, 5.5)]
        public void PercentageTestfirst(decimal first, decimal second, bool[] operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.pluswasclicked = operation[0];
            test1.minuswasclicked = operation[1];
            test1.multiplywasclicked = operation[2];
            test1.dividewasclicked = operation[3];
            test1.first = first;
            test1.second = second;
            test1.percentageOperation();
            Assert.Equal(expected.ToString(), test1.first.ToString());
        }
        [Theory]
        [InlineData(0, 0, new bool[] { false, false, false, false }, 0)]
        [InlineData(550, 12, new bool[] { true, true, true, true }, 0.12)]
        [InlineData(550, 12, new bool[] { true, false, false, false}, 0.12)]
        public void PercentageTestsecond(decimal first, decimal second, bool[] operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.pluswasclicked = operation[0];
            test1.minuswasclicked = operation[1];
            test1.multiplywasclicked = operation[2];
            test1.dividewasclicked = operation[3];
            test1.first = first;
            test1.second = second;
            test1.percentageOperation();
            Assert.Equal(expected.ToString(), test1.second.ToString());
        }
        [Theory]
        [InlineData("10",10)]
        [InlineData("1.4",1.4)]
        [InlineData("-60",-60)]
        public void ConverterTestfirst(string number,decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.number.Append(number);
            test1.converter();
            Assert.Equal(expected, test1.first);
            Assert.True(test1.second == 0);
        }
        [Theory]
        [InlineData("50",50)]
        [InlineData("5.2",5.2)]
        [InlineData("-69",-69)]
        public void ConverterTestsecond(string number,decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.number.Append(number);
            test1.pluswasclicked = true;
            test1.converter();
            Assert.Equal(expected, test1.second);
            Assert.True(test1.first == 0);
        }
        [Theory]
        [InlineData(30, new bool[] { true, false, false, false, false, false, false }, 0.5)]//sin
        [InlineData(20, new bool[] { false, true, false, false, false, false, false }, 0.94)]//cos
        [InlineData(50, new bool[] { false, false, true, false, false, false, false }, 1.192)]//tan
        [InlineData(0.2, new bool[] { false, false, false, true, false, false, false }, 11.537)]//sin^-1
        [InlineData(0.5, new bool[] { false, false, false, false, true, false, false }, 60)]//cos^-1
        [InlineData(0.4, new bool[] { false, false, false, false, false, true, false }, 21.801)]//tan^-1
        [InlineData(16, new bool[] { false, false, false, false, false, false, true }, 4)]//sqrt
        [InlineData(12.9, new bool[] { false, false, false, false, false, false, false }, 0)]//all false test
        [InlineData(90, new bool[] { true, false, false, false, false, true,false }, 1)]
        public void TrigoSqrtTest(decimal value, bool[] operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.sinwasclicked = operation[0];
            test1.coswasclicked = operation[1];
            test1.tanwasclicked = operation[2];
            test1.sinhwasclicked = operation[3];
            test1.coshwasclicked = operation[4];
            test1.tanhwasclicked = operation[5];
            test1.square_rootwasclicked = operation[6];
            decimal actual = test1.TrigoSqrtOption(value);
            Assert.Equal(expected, actual, 3);
        }
        [Theory]
        [InlineData(30, new bool[] { true, false, false, false, false, false, false }, 0.5)]//sin
        [InlineData(20, new bool[] { false, true, false, false, false, false, false }, 0.94)]//cos
        [InlineData(50, new bool[] { false, false, true, false, false, false, false }, 1.192)]//tan
        [InlineData(0.2, new bool[] { false, false, false, true, false, false, false }, 11.537)]//sin^-1
        [InlineData(0.5, new bool[] { false, false, false, false, true, false, false }, 60)]//cos^-1
        [InlineData(0.4, new bool[] { false, false, false, false, false, true, false }, 21.801)]//tan^-1
        [InlineData(16, new bool[] { false, false, false, false, false, false, true }, 4)]//sqrt
        [InlineData(90, new bool[] { true, false, false, false, false, true, false }, 1)]
        public void CalcTrigoSqrtTestfirst(decimal first, bool[] operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.sinwasclicked = operation[0];
            test1.coswasclicked = operation[1];
            test1.tanwasclicked = operation[2];
            test1.sinhwasclicked = operation[3];
            test1.coshwasclicked = operation[4];
            test1.tanhwasclicked = operation[5];
            test1.square_rootwasclicked = operation[6];
            test1.first = first;
            test1.second = 0;
            bool result = test1.CalcTrigoSqrt();
            Assert.Equal(expected, test1.first, 3);
            Assert.True(result);
        }
        [Theory]
        [InlineData(30, 30, new bool[] { true, false, false, false, false, false, false }, 0.5)]//sin
        [InlineData(20, 20, new bool[] { false, true, false, false, false, false, false }, 0.94)]//cos
        [InlineData(50, 50, new bool[] { false, false, true, false, false, false, false }, 1.192)]//tan
        [InlineData(0.2, 0.2, new bool[] { false, false, false, true, false, false, false }, 11.537)]//sin^-1
        [InlineData(0.5, 0.5, new bool[] { false, false, false, false, true, false, false }, 60)]//cos^-1
        [InlineData(0.4, 0.4, new bool[] { false, false, false, false, false, true, false }, 21.801)]//tan^-1
        [InlineData(16, 16, new bool[] { false, false, false, false, false, false, true }, 4)]//sqrt    
        [InlineData(90, 90, new bool[] { true, false, false, false, false, true, false }, 1)]
        public void CalcTrigoSqrtTestsecond(decimal first, decimal second, bool[] operation, decimal expected)
        {
            Arithmetic test1 = new Arithmetic();
            test1.sinwasclicked = operation[0];
            test1.coswasclicked = operation[1];
            test1.tanwasclicked = operation[2];
            test1.sinhwasclicked = operation[3];
            test1.coshwasclicked = operation[4];
            test1.tanhwasclicked = operation[5];
            test1.square_rootwasclicked = operation[6];
            test1.first = first;
            test1.second = second;
            bool result=test1.CalcTrigoSqrt();
            Assert.Equal(expected, test1.second, 3);
            Assert.False(result);
        }

    }
}
