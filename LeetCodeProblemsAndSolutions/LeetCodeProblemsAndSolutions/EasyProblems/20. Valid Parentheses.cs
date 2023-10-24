using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.
 
//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false

//Constraints:

//1 <= s.length <= 104
//s consists of parentheses only '()[]{}'.

namespace LeetCodeProblemsAndSolutions.EasyProblems
{

    //Resolved problem using stack, if the stack is empty at the end of the execution, the parantheses are valid.
    public static class ValidParantheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    stack.Push(bracket);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char openBracket = stack.Pop();

                    if ((bracket == ')' && openBracket != '(') ||
                        (bracket == '}' && openBracket != '{') ||
                        (bracket == ']' && openBracket != '['))
                    {
                        return false;
                    }
                }
            }

            // If the stack is empty, all brackets have been matched correctly
            return stack.Count == 0;
        }
    }
}
