using GreetingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CheckAge.Test
{
    public class UnitTestOfAge
    {
        [Fact]
        public void GreetingReturnCanDrive()
        {
            AgeCheck message = new AgeCheck();
            string expected = "You can Drive";
            string actual = message.CheckTheAge(21);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void GreetingReturnCanNotDrive()
        {
            AgeCheck message = new AgeCheck();
            string expected = "You can not Drive";
            string actual = message.CheckTheAge(17);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "You can not Drive")]
        [InlineData(2, "You can not Drive")]
        [InlineData(3, "You can not Drive")]
        [InlineData(4, "You can not Drive")]
        [InlineData(5, "You can not Drive")]
        [InlineData(6, "You can not Drive")]
        [InlineData(7, "You can not Drive")]
        [InlineData(8, "You can not Drive")]
        [InlineData(9, "You can not Drive")]
        [InlineData(10, "You can not Drive")]
        [InlineData(11, "You can not Drive")]
        [InlineData(12, "You can not Drive")]
        [InlineData(13, "You can not Drive")]
        [InlineData(14, "You can not Drive")]
        [InlineData(15, "You can not Drive")]
        [InlineData(16, "You can not Drive")]
        [InlineData(17, "You can not Drive")]
        [InlineData(18, "You can Drive")]
        [InlineData(19, "You can Drive")]
        [InlineData(20, "You can Drive")]

        public void GreetingShouldReturnDrivingLicenceInformation(int currentAge, string expected)
        {

            AgeCheck message = new AgeCheck();
            string actual = message.CheckTheAge(currentAge);

            Assert.Equal(expected, actual);


        }
    }
}
