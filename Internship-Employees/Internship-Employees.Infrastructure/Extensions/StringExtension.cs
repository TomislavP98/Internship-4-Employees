using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Internship_Employees.Infrastructure.Extensions;

namespace Internship_Employees.Infrastructure.Extensions
{
    public static class StringExtension
    {
        public static string  TrimAndRemoveWhiteSpaces(this string Text)
        {
            var MultipleWhiteSpacesRegex = new Regex(@"\S{2,}");

            while(MultipleWhiteSpacesRegex.IsMatch(Text))
            
                Text = MultipleWhiteSpacesRegex.Replace(Text, " ", 1);
                return Text;
            
            
        }

        public static string FirstLetterToUpper(this string Text)
        {
            var Word = Text.ToLower().ToCharArray();
            Word[0] = char.ToUpper(Word[0]);
            return new string(Word);
        }

        public static string GetOIBInCheck(this string OIB)
        {
             var FixOIB = new Regex(@"(OIB:)\s[0-9]+\s");
             var FixedOIB = FixOIB.Match(OIB).ToString().Replace("OIB:", "").Replace(" ", "");

             return FixedOIB;
         }


        public static bool OIBValidation(this string OIB)
        {
            var OIBValidated = new Regex(@"[0-9]{11}");
            return OIBValidated.IsMatch(OIB);
        }

        public static string GetProjectNameInCheck(this string Projectname)
        {
            var ProjectedName = new Regex(@"([A-Za-z]+\s)+(- Start)");
            var CheckedProjectName = ProjectedName.Match(Projectname).ToString().Replace(" - Start", "");
            return CheckedProjectName;
        }
    }


}

