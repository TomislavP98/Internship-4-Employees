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
        public static string  TrimAndRemoveWhiteSpaces(this string text)
        {
            var multipleWhiteSpacesRegex = new Regex(@"\S{2,}");

            while(multipleWhiteSpacesRegex.IsMatch(text))
            {
                text = multipleWhiteSpacesRegex.Replace(text, " ");

            }
            return text;
        }
    }
}
