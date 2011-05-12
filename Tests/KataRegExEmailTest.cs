using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RegexKata.Results;

namespace RegexKata
{

    /// <summary>
    /// Make sure you have first completed KataRegExAlphanumbericTest.cs
    /// Create a boolean method that will take a string and check that it is an email.
    /// One test will pass in a correct email address (eg. andrewwebb@gmail.com)
    /// One test will pass in a correct email address more complicated (eg. andrew.webb_234@gmail.dns.com)
    /// One test will pass in a incorect result (eg. andrewwebb.gmail.com)
    /// One test will pass in a incorect result no domain (eg. andrewwebb@gmail)
    /// One Test will pass in an empty string
    /// One Test will pass in an null string
    /// </summary>
    [TestFixture]
    public class KataRegExAnEmailTest
    {

        [Test]
        public void CheckStringContainsCorrectEmailAddress()
        {   
            
            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrewwebb@gmail.com";

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CheckStringContainsCorrectEmailAddressComplicated()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrew.webb_234@gmail.dns.com";

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsTrue(result);

        }


        [Test]
        public void CheckStringContainsInCorrectEmailAddressNoAt()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrewwebb.gmail.com";

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }



        [Test]
        public void CheckStringContainsInCorrectEmailAddressNoDomain()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrewwebb@gmail";

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }


        [Test]
        public void CheckStringIfEmpty()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"";

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }

        [Test]
        public void CheckStringIfNull()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            string testString = null;

            //Act
            bool result = regexHelper.CheckLiteralIsEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }

    

    }
}
