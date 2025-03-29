
using System.Text.RegularExpressions;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string Sentence)
        {
            Stack<char> palindrom = new Stack<char>();
            string _sentence = Regex.Replace(Sentence, @"[^a-zA-Z]", "").ToLower();
            char[] sentence = _sentence.ToCharArray();

            int len = sentence.Length / 2;
            len = len % 2 == 0 ? len : len + 1;
            for(int i = 0; i < len; i++)
            {
                palindrom.Push(sentence[i]);
            }

            if(sentence.Length % 2 == 0)
            {
                for(int i = len, n = sentence.Length; i < n; i++)
                {
                    if (sentence[i] >= 'a' && sentence[i] <= 'z')
                    {
                        if (sentence[i] == palindrom.Peek())
                        {
                            palindrom.Pop();
                        } else
                        {
                            return false;
                        }
                    }
                }
            } else
            {
                for(int i = len + 1, n = sentence.Length; i < n; i++)
                {
                    if (sentence[i] >= 'a' && sentence[i] <= 'z')
                    {
                        if (sentence[i] == palindrom.Peek())
                        {
                            palindrom.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (palindrom.Count == 0) return true;
            return false;
        }
    }
}
