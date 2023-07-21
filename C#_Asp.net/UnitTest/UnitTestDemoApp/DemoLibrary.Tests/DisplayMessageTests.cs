using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange , Act , Assert

//Expected and actual

namespace DemoLibrary.Tests
{
    public class DisplayMessageTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessage message = new DisplayMessage(); 
            string expected = "Good Morning Tim";
            // Act
            string actual = message.Greetings("Tim" ,6);
           // Assert
           Assert.Equal(expected, actual);

        }
        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessage message = new DisplayMessage();
            string expected = "Good Afternoon Tim";
            // Act
            string actual = message.Greetings("Tim", 14);
            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void GreetingShouldReturnGoodEveningMessage()
        {
            // Arrange
            DisplayMessage message = new DisplayMessage();
            string expected = "Good Evening Tim";
            // Act
            string actual = message.Greetings("Tim", 20);
            // Assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData("Tim",0,"Go to bed Tim")]
        [InlineData("Tim",1, "Go to bed Tim")]
        [InlineData("Tim",2, "Go to bed Tim")]
        [InlineData("Tim",3,"Go to bed Tim")]
        [InlineData("Tim",4,"Go to bed Tim")]
        [InlineData("Tim",5,"Good Morning Tim")]
        [InlineData("Tim",6,"Good Morning Tim")]
        [InlineData("Tim",7,"Good Morning Tim")]
        [InlineData("Tim",8,"Good Morning Tim")]
        [InlineData("Tim",9,"Good Morning Tim")]
        [InlineData("Tim",10,"Good Morning Tim")]
        [InlineData("Tim",11,"Good Morning Tim")]
        [InlineData("Tim",12,"Good Afternoon Tim")]
        [InlineData("Tim",13,"Good Afternoon Tim")]
        [InlineData("Tim",14, "Good Afternoon Tim")]
        [InlineData("Tim",15,"Good Afternoon Tim")]
        [InlineData("Tim",16,"Good Afternoon Tim")]
        [InlineData("Tim",17,"Good Afternoon Tim")]
        [InlineData("Tim",18,"Good Evening Tim")]
        [InlineData("Tim",19,"Good Evening Tim")]
        [InlineData("Tim",20, "Good Evening Tim")]
        [InlineData("Tim",21, "Good Evening Tim")]
        [InlineData("Tim",22, "Good Evening Tim")]
        [InlineData("Tim",23, "Good Evening Tim")]
        public void GreetingShouldReturnExpectedValue(string firstName,int hourOfTheDay,string expected)
        {   

            DisplayMessage message = new DisplayMessage();

            string actual = message.Greetings(firstName, hourOfTheDay);

            Assert.Equal(expected, actual);
        }
    }
}
