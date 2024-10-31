using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Decode
{
    static class Decoding
    {
       private static string DecodeUnicodeString(string input)
        {
            return Regex.Replace(input, @"\\u(?<value>[0-9a-fA-F]{4})", match =>
            {
                int codePoint = Convert.ToInt32(match.Groups["value"].Value, 16);
                return char.ConvertFromUtf32(codePoint);
            });
        }
       public static string Decode(string input)
        {
            string temp = DecodeUnicodeString(input);
            byte[] bytes = Encoding.GetEncoding("Windows-1252").GetBytes(temp);
            string decodedString = Encoding.UTF8.GetString(bytes);
            return decodedString;
        }
    }
}
