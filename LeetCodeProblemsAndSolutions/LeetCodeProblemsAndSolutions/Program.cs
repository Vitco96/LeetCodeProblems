﻿using LeetCodeProblemsAndSolutions.EasyProblems;
using LeetCodeProblemsAndSolutions.MediumProblems;

namespace LeetCodeProblemsAndSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 100;
            // FizzBuzz.RunMethod(a);

            //var romanString = "MCMXIV";
            //Console.WriteLine(Roman_to_Integer.RomanToIntDictionary(romanString));
            //Console.WriteLine(Roman_to_Integer.RomanToInt(romanString));

            //LinkedList<int> firstNumber = new LinkedList<int>(new int[] { 2, 4, 3 });
            //LinkedList<int> secondNumber = new LinkedList<int>(new int[] { 5, 6, 4});
            //var list = AddTwoNumbersProblem.AddTwoNumbers(firstNumber, secondNumber);
            //Console.WriteLine("Result : ");
            //foreach(int i in list) { Console.WriteLine(i); }

            // var input = "abba";
            // Console.WriteLine(LongestSubstring.LengthOfLongestSubstring(input));

            // var parantheses = "()";
            // Console.WriteLine(ValidParantheses.IsValid(parantheses));
            // parantheses = "()[]{}";
            // Console.WriteLine(ValidParantheses.IsValid(parantheses));
            // parantheses = "(]";
            // Console.WriteLine(ValidParantheses.IsValid(parantheses));

            // var a = "   fly me   to   the moon  ";
            // Console.WriteLine(LengthOfLastWordProblem.LengthOfLastWord(a));

            int[] digits = [9, 9, 9];
            var a = PlusOneProblem.PlusOne(digits);
            var b = 2;
        }
    }
}
