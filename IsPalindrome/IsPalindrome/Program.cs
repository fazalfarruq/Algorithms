using System;
using System.Text;

namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GetFirstLetter(string str)
        {

            if (str.Length == 1) { return str; }
            return str.ToCharArray()[0].ToString();
        }

        public static string GetLastLetter(string str)
        {

            if (str.Length == 1) { return str; }
            return str.ToCharArray()[str.Length - 1].ToString();
        }

        public static string GetMiddleString(string str1)
        {
            var temp = str1.Substring(1, str1.Length - 2);
            return temp;
        }

        public static bool IsPalidrome(string str)
        {

            if (str.Length <= 1) return true;
            var firstLetter = GetFirstLetter(str);
            var lastLetter = GetLastLetter(str);
            if (firstLetter == lastLetter)
            {
                var str1 = GetMiddleString(str);
                return IsPalidrome(str1);
            }

            return false;
        }

        public static string SimpleReducedString(string str)
        {
            if (str.Length < 1)
                return string.Empty;
            StringBuilder build = new StringBuilder(str);

            for (int i = 0; i < str.Length - 1; i++)
            {

                var first = str[i];
                var next = str[i + 1];
                if (first == next)
                {

                    build = build.Remove(i, 1);
                    build = build.Remove(i, 1);
                    return SimpleReducedString(build.ToString());
                }
            }
            return str;
        }
    }
}
