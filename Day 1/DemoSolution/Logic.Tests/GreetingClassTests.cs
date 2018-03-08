using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logic.GreetingClass;

namespace Logic.Tests
{
    [TestClass]
    public class GreetingClassTests
    {
        [TestMethod]
        public void GreetingMethod_HelloConcatWithJonSkeet_ReturnHelloJonSkeet()
        {
            // Arrange Act Assert (AAA) Pattern

            // Arrange
            string userName = "Jon Skeet";
            string expected = $"Hello, {userName}!";
            Debug.WriteLine("Output the information in debug, if necessary.");

            // Act
            string actual = GreetingMethod(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GreetingMethod_HelloConcatWithNull_ThrowArgumentNullException()
                => GreetingMethod(null);

        [TestMethod]
        public void GreetingMethod_HelloConcatWithEmptyString_ReturnedHelloAnonim()
        {
            string userName = string.Empty;

            string expected = "Hello, anonim!";

            string actual = GreetingMethod(userName);

            Assert.AreEqual(expected, actual);
        }
    }
}