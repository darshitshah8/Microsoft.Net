using GreetingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestHomework.Test
{
    public class AgeCheckUnitTest
    {
        [Theory]
        [InlineData(1, "You can not drive")]
        [InlineData(2, "You can not drive")]
        public void GreetingShouldReturnDrivingLicenceInformation(int currentAge,string expected)
        {
            
            AgeCheck message = new AgeCheck();
            string actual = message.CheckTheAge(currentAge);

            Assert.Equal(expected, actual);


        }
    }
}
