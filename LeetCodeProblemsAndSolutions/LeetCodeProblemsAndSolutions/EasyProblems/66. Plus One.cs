using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
