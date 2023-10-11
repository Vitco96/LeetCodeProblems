namespace LeetCodeProblemsAndSolutions.EasyProblems;

// Given an integer x, return true if x is a palindrome, and false otherwise.
//
// Example 1:
//
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.
// Example 2:
//
// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
// Example 3:
//
// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
//
//
// Constraints:
//
// -231 <= x <= 231 - 1
//
//
// Follow up: Could you solve it without converting the integer to a string?

public static class Palindrome_Number
{
    //The first solution is a solution in which we convert the number into a list and we check if the number at the
    //first index is equal with the number at the last index and so on, but this solution is less efficient than
    //the second one.
    public static bool IsPalindromeUsingList(int x)
    {
        if (x == 0) return true;
        if (x <= 0 || x % 10 == 0) return false;

        List<int> numberToList  = new List<int>();
        int length = 0;

        while(x > 0)
        {
            numberToList.Add(x % 10);
            x = x / 10;
            length++;
        }

        for(int i = 0; i < length / 2; i++)
        {
            if(numberToList[i] != numberToList[length - (i+1)]) return false;
        }

        return true;
    }

    //This solution is faster than the first one, it basically splits the number into two parts and one of the parts
    //will be reverted, if both numbers are equal, it means the number is a palindrome.
    public static bool IsPalindrome(int x)
    {
        if(x == 0 ) return true;

        if (x < 0 || x % 10 == 0) return false;

        var half = 0;

        while (half < x)
        {
            half = (half * 10) + (x % 10);
            x /= 10;
        }

        if(x == half || x == half / 10) return true;

        return false;
    }
}
