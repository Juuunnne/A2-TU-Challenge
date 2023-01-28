using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i += 2)
                result += input[i];
            for (int i = 1; i < input.Length; i += 2)
                result += input[i];
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0)
                return true;
            foreach (char c in input)
            {
                if (c != ' ') return false;
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
                throw new ArgumentException("argument is not valid ");
            string result = "";
            int i;
            // Alternate
            for (i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                result += a[i].ToString() + b[i].ToString();
            }

            // add the remaining chars at the end of the longest string
            if (a.Length > b.Length) b = a;
            for (int j = i; j < b.Length; j++)
            {
                result += b[j].ToString();
            }
            return result;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";
            foreach (char c in input)
            {
                if ('a' <= c && c <= 'z')
                {
                    result += (char)((c - 'a' + offset) % 26 + 'a');
                }

                else if ('A' <= c && c <= 'Z')
                {
                    result += (char)((c - 'A' + offset) % 26 + 'A');
                }

                else result += c;
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            string tmp1 = input.Substring(0, input.Length / 2);
            string tmp2 = input.Substring(input.Length / 2);
            return MixString(tmp1, tmp2);
        }

        public static string Voyelles(string a)
        {
            throw new NotImplementedException();
        }
    }
}
