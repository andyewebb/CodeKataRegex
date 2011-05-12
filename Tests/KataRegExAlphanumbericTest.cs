using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RegexKata.Results;

namespace RegexKata
{

    /// <summary>
    /// Create a boolean method that will take a string and check that it only contains numbers and letters. Nulls and empty strings should fail.
    /// One test will pass in a correct result with just letters (eg. andrewwebb)
    /// One test will pass in a correct result with just numbers (eg. 123456)
    /// One test will pass in a correct result with numbers and letters (eg. andrewwebb1)
    /// One test will pass in an incorrect result (eg. andrew$webb1)
    /// One Test will pass in an empty string
    /// One Test will pass in an null string
    /// </summary>
    [TestFixture]
    public class KataRegExAlphanumbericTest
    {

        [Test]
        public void CheckStringContainsLettersWithCorrectLetters()
        {   
            
            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrewwebb";

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CheckStringContainsNumbersWithCorrectNumbers()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"123456";

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsTrue(result);

        }


        [Test]
        public void CheckStringContainsNumbersLettersWithCorrectLettersAndNumbers()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrewwebb1";

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CheckStringContainsNumbersLettersWithInCorrectString()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"andrew$webb1";

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsFalse(result);

        }

        [Test]
        public void CheckStringContainsNumbersLettersWithNull()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            string testString = null;

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsFalse(result);

        }


        [Test]
        public void CheckStringContainsNumbersLettersWithEmptyString()
        {

            //Arrange
            IRegexHelper regexHelper = new RegexHelper();
            var testString = @"";

            //Act
            bool result = regexHelper.CheckLiteralIsAlphaNumeric(testString);

            //Assert
            Assert.IsFalse(result);

        }


    }
}
