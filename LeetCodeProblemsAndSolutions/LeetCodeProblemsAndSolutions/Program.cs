using LeetCodeProblemsAndSolutions.EasyProblems;
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

            LinkedList<int> firstNumber = new LinkedList<int>(new int[] { 2, 4, 3 });
            LinkedList<int> secondNumber = new LinkedList<int>(new int[] { 5, 6, 4});
            var list = AddTwoNumbersProblem.AddTwoNumbers(firstNumber, secondNumber);
            Console.WriteLine("Result : ");
            foreach(int i in list) { Console.WriteLine(i); }
        }
    }
}
