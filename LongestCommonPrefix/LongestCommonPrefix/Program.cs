using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string total = Console.ReadLine();
            int total1 = Int32.Parse(total);
            string[] strs = new string[total1];
            for (int i = 0; i < total1; i++)
            {
                strs[i] = Console.ReadLine();
            }
            string result = LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            char[] charArray = new char[strs[0].Length];
            int count = 0;
            foreach (string s in strs)
            {
                char[] next = s.ToCharArray();
                for (int i = 0; i < next.Length; i++)
                {
                    if (count == 0)
                    {
                        charArray[i] = next[i];
                    }
                    else
                    {
                        if (charArray.Length == 0)
                        {
                            return "";
                        }
                        if (i >= charArray.Length)
                        {
                            break;
                        }
                        if (!charArray[i].Equals(next[i]))
                        {
                            charArray = RemoveRest(charArray, i);
                            if (charArray.Length == 0)
                            {
                                return "";
                            }
                            break;
                        }
                        else
                        {
                            if (charArray.Length > next.Length)
                            {
                                charArray = RemoveRest(charArray, next.Length);
                            }
                        }
                    }
                }
                count++;
            }
            string result = new string(charArray);
            return result;
        }
        private static char[] RemoveRest(char[] charArray, int i)
        {
            string str = new string(charArray);
            str = str.Remove(i, charArray.Length - i);
            return str.ToCharArray();
        }
    }
}
