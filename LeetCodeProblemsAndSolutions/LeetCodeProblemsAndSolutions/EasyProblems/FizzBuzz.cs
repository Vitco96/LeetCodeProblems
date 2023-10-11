namespace LeetCodeProblemsAndSolutions.EasyProblems;

//Fizz Buzz Game
//Print all numbers until a maximum number, if the number is divisible by 3, print Fizz instead of the number
//If the number is divisible by 5 print Buzz instead of the number
//If the number is divisible by 3 and 5 print FizzBuzz
public static class FizzBuzz
{
    //This implementation avoids multiple ifs, and complex conditions.
    public static void RunMethod(int maximumNumber)
    {
        for (int i = 0; i <= maximumNumber; i++)
        {
            string helperString = "";

            if (i % 3 == 0) helperString += "Fizz";
            if (i % 5 == 0) helperString += "Buzz";

            if (helperString == "")
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(helperString);
            }
        }
    }
}
