using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RegexKata.Results;

namespace RegexKata
{

    /// <summary>
    /// Make sure you have first completed KataRegExAlphanumbericTest.cs and KataRegExEmailTest.cs
    /// Create a boolean method that will take a string and check that it is an LSC email.
    /// One test will pass in a correct email address (eg. anw@lsc.co.uk)
    /// One test will pass in a inccorrect email address (eg. anw@lscv.co.uk)  
    /// One test will pass in a correct email address (eg. anw@lsc-group.co.uk) - We have decieced to start using the lsc-group domain!
    /// One Test will pass in an empty string
    /// One Test will pass in an null string
    /// </summary>
    [TestFixture]
    public class KataRegExAnLscEmailTest
    {

        [Test]
        public void CheckStringContainsCorrectEmailAddress()
        {   
            
            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"anw@lsc.co.uk";

            //Act
            bool result = regexHelper.CheckLiteralIsALscEmail(testString);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CheckStringContainsCorrectEmailAddressComplicated()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"anw@lscv.co.uk";

            //Act
            bool result = regexHelper.CheckLiteralIsALscEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }



        [Test]
        public void CheckStringContainsCorrectLscGroupEmailAddress()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"anw@lsc-group.co.uk";

            //Act
            bool result = regexHelper.CheckLiteralIsALscEmail(testString);

            //Assert
            Assert.IsTrue(result);

        }
     

        [Test]
        public void CheckStringIfEmpty()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"";

            //Act
            bool result = regexHelper.CheckLiteralIsALscEmail(testString);

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
            bool result = regexHelper.CheckLiteralIsALscEmail(testString);

            //Assert
            Assert.IsFalse(result);

        }

    

    }
}
