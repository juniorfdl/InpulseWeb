using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inpulse.WebApi.Base
{
    public static class StringExtensions
    {
        private const string CommaSeparator = ",";
        private const string SemicolonSeparator = ";";
        
        public static string Format(this string format, params object[] values) 
            => string.Format(format, values);

        public static string ToSentenceCase(this string str) 
            => Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {m.Value[1]}");

        public static bool EqualsIgnoringCase(this string text, string otherText) 
            => text.Equals(otherText, StringComparison.InvariantCultureIgnoreCase);

        public static IEnumerable<string> SplitComma(this string value)
            => value?.SplitBySeparator(CommaSeparator);

        public static IEnumerable<string> SplitSemicolon(this string value)
            => value?.SplitBySeparator(SemicolonSeparator);
        
        public static IEnumerable<string> SplitBySeparator(this string value, string separator) 
            => !string.IsNullOrEmpty(value)
                ? value.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList()
                : Enumerable.Empty<string>();
        
        public static string JoinComma(this IEnumerable<string> value, bool whiteSpace = true) 
            => string.Join(whiteSpace ? CommaSeparator : $"{CommaSeparator} ", value ?? new string[] { });
    }
}