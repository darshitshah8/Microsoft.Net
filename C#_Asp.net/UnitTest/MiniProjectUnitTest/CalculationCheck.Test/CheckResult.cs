using CalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculationCheck.Test
{
    public class CheckResult
    {
        [Fact]
        public void CheckResultShouldReturnCorrectAddition()
        {
            CalculationModule result = new CalculationModule(); 
            int expected = 9;
            int actual = result.Add(4,5); 
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckResultShouldReturnCorrectSubstraction()
        {
            CalculationModule result = new CalculationModule();
            int expected = -1;
            int actual = result.Sub(4, 5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckResultShouldReturnCorrectMultiplication()
        {
            CalculationModule result = new CalculationModule();
            int expected = 20;
            int actual = result.Mul(4, 5);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(70,2,35)]
        [InlineData(70,35,2)]
        [InlineData(70,5,14)]
        [InlineData(70,7,10)]
        [InlineData(70,10,7)]
        [InlineData(70,14,5)]
        public void CheckResultShouldReturnCorrectDivision(double num1,double num2,double expected)
        {
            CalculationModule result = new CalculationModule();
           
            double actual = result.Div(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
