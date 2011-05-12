using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegexKata.Results
{
    interface IRegexHelper
    {

        bool CheckLiteralIsAlphaNumeric(string literal);
        bool CheckLiteralIsEmail(string literal);
        bool CheckLiteralIsALscEmail(string literal);

    }
}
