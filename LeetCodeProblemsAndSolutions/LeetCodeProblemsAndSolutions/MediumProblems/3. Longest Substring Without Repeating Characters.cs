//Given a string s, find the length of the longest  substring without repeating characters.

//Example 1:

//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3.
//Example 2:

//Input: s = "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
//Example 3:

//Input: s = "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3.
//Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

using System.Text;

namespace LeetCodeProblemsAndSolutions.MediumProblems
{
    public static class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            StringBuilder subStr = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (subStr.Length > 0)
                    {
                        if (!subStr.ToString().Contains(s[j]))
                        {
                            subStr.Append(s[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        subStr.Append(s[j]);
                    }
                }

                if (subStr.Length > maxLength)
                    maxLength = subStr.Length;

                subStr = new StringBuilder();
            }

            return maxLength;
        }

        public static bool IsPalindrome(string input)
        {
            // Remove spaces and convert the string to lowercase
            string cleanedString = input.Replace(" ", "").ToLower();

            // Compare the cleaned string with its reverse
            for (int i = 0; i < cleanedString.Length / 2; i++)
            {
                if (cleanedString[i] != cleanedString[cleanedString.Length - i - 1])
                {
                    // Characters at symmetric positions are not equal, not a palindrome
                    return false;
                }
            }
            // All characters match, it's a palindrome
            return true;
        }
    }
}
