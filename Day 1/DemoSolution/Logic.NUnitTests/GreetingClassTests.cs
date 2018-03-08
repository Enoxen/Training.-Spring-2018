using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using static Logic.GreetingClass;

namespace Logic.NUnitTests
{
    using System.Collections;

    [TestFixture]
    public class GreetingClassTests
    {
        // First variant
        [TestCase("Jon Skeet", ExpectedResult = "Hello, Jon Skeet!")]
        [TestCase("", ExpectedResult = "Hello, anonim!")]
        public string GreetingMethod_HelloConcatUserName(string userName) 
                => GreetingMethod(userName);

        // Second variant
        [Test, TestCaseSource(typeof(DataForTests), nameof(DataForTests.TestCases))]
        public string GreetingMethod_HelloConcatUserNameWithYield(string userName)
        {
            Debug.WriteLine("Output the information in debug, if necessary.");
            return GreetingMethod(userName);
        }

        [Test]
        public void GreetingMethod_WithNull_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => GreetingMethod(null));
    }

    // For second Variant
    public class DataForTests
    {  
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("Jon Skeet").Returns("Hello, Jon Skeet!");
                yield return new TestCaseData(string.Empty).Returns("Hello, anonim!");
            }
        }
    }
}
