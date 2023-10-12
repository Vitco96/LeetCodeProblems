using LeetCodeProblemsAndSolutions.EasyProblems;

namespace LeetCodeProblemsAndSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 100;
            // FizzBuzz.RunMethod(a);

            var romanString = "MCMXIV";
            Console.WriteLine(Roman_to_Integer.RomanToIntDictionary(romanString));
            Console.WriteLine(Roman_to_Integer.RomanToInt(romanString));
        }
    }
}
