using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.

 

//Example 1:

//Input: digits = [1, 2, 3]
//Output: [1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1, 2, 4].
//Example 2:

//Input: digits = [4, 3, 2, 1]
//Output: [4,3,2,2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4, 3, 2, 2].
//Example 3:

//Input: digits = [9]
//Output: [1,0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1, 0].


//Constraints:

//1 <= digits.length <= 100
//0 <= digits[i] <= 9
//digits does not contain any leading 0's.

namespace LeetCodeProblemsAndSolutions.EasyProblems
{
    //SOLUTION BEATS 98% of C# USERS)
    //First we check if the last element is less than 9 and if it is we return the array with only the last item increased.
    //Second we check if all the elements are 9, and if they are we create a new array which is longer with 1, the first element is one and the rest 0
    //Third we use the carry logic in a do while structure
    public static class PlusOneProblem
    {
        public static int[] PlusOne(int[] digits)
        {
            if(digits.Last() < 9)
            {
                digits[digits.Length - 1]++;
                return digits;
            }

            if (digits.All(x => x.Equals(9)))
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                for (int i = 1; i < newDigits.Length; i++) newDigits[i] = 0;
                return newDigits;
            }

            var carry = false;
            var iterator = digits.Length - 1;

            do
            {
                carry = false;
                digits[iterator]++;

                if (digits[iterator] == 10)
                {
                    digits[iterator] = 0;
                    carry = true;
                }

                iterator--;
            } while (carry);

            return digits;
        }
    }
}
