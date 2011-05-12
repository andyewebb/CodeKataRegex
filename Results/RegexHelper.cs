using System;
using System.Text.RegularExpressions;

namespace RegexKata.Results
{
    public class RegexHelper : IRegexHelper
    {
        public bool CheckLiteralIsAlphaNumeric(string literal)
        {
            if (String.IsNullOrEmpty(literal)) return false;
           //const string pattern = "[0-9a-z]";
           //changed to this pattern even simplier /w does alphanumeric!
            const string pattern = @"^([\w])*$";
            return(Regex.IsMatch(literal, pattern));

        }

        public bool CheckLiteralIsEmail(string literal)
        {
            if (String.IsNullOrEmpty(literal)) return false;
           //after lots of messing about this is a very simple patter that will do a simple match

            const string pattern = @".+\@.+\..+";
            return (Regex.IsMatch(literal, pattern));

        }


        public bool CheckLiteralIsALscEmail(string literal)
        {
            if (String.IsNullOrEmpty(literal)) return false;
           //more messing about
           //  const string pattern3 =
           //     @"([a-z0-9][-a-z0-9_\+\.]*[a-z0-9])@.+(lsc.co.uk)";
            //const string pattern2 = @".+\@.+((lsc.co.uk)|(lsc-group.co.uk))$";
            const string pattern = @".+\@(lsc.co.uk|lsc-group.co.uk)";
            return (Regex.IsMatch(literal, pattern));

        }
        

    }
}