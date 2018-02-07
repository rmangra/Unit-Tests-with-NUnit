using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IntroToNUnit
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    */
    public static class EnumToStringConverter
    {
        public static string ToFriendlyString(this Enum value)
        {
            var text = value.ToString();
            var regex = new Regex(@"[\p{Lu}|^\p{Ll}]\p{Ll}*");
            var split = from Match match in regex.Matches(text) select match.Value.InitialCapital();
            return string.Join(" ", split);
        }

        public static string InitialCapital(this string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return word;

            return word.First().ToString().ToUpper() + word.Substring(1);
        }
    }
}
