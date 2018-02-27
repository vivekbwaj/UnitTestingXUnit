using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MySource;
using Xunit.Abstractions;

namespace CalculatorTests
{
   public class CalcTests
    {
        private readonly ITestOutputHelper _output;
        public CalcTests(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("This is setup method");
        }

        [Fact]
        public void Addtest()
        {
            var number1 = 10;
            var number2 = 20;
            var expected = 30;

            Calculator calculator = new Calculator();
            var result = calculator.Add(number1, number2);
            _output.WriteLine("Adding {0} and {1} gives {2} and expected is {3}", number1,number2,result, expected);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 10, 30)]
        [InlineData(20, 20, 40)]
        public void AddTest2(int number1, int number2, int expected)
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(number1, number2);
            _output.WriteLine("Adding {0} and {1} gives {2} and expected is {3}", number1, number2, result, expected);
            Assert.Equal(expected, result);
        }
    }
}
