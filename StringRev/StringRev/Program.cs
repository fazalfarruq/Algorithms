using System;

namespace StringRev
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "thisismeinorder";
            var result = Rev(s);

        }

        static string Rev(string st)
        {

            char[] charArray = st.ToCharArray();
            var arraySize = charArray.Length;
            char[] revArray = new char[arraySize];

            for (int i = 0; i < charArray.Length; i++)
            {
                revArray[i] = charArray[arraySize - 1];
                --arraySize;
            }
            return string.Concat(revArray);

        }


        static string Rev2(string st)
        {

            char[] charArray = st.ToCharArray();
            var arraySize = charArray.Length;
            char[] revArray = new char[arraySize];

            for (int i = 0; i < charArray.Length; i++)
            {
                revArray[i] = charArray[arraySize - 1];
                --arraySize;
            }
            return string.Concat(revArray);

        }
    }
}
