using System;
using static System.Console;

namespace Challenge_GuessNumber;
class Program
{
    static void Main(string[] args)
    {
        int answer = new Random().Next(20);
        int tries = 1;
        int startNum = 0;
        int endNum = 20;
        string guessStr;
        bool success = false;

        WriteLine("Let's plat a game...");
        WriteLine($"Guess the number I'm thinking of between {startNum} and {endNum}...");

        do
        {   
            // Get number guess from the users
            guessStr = Console.ReadLine();
            tries++;
            try
            {
                int guess = Int32.Parse(guessStr);
                if (guess == answer)
                {
                    WriteLine($"You got it right with {tries} tries!");
                    success = true;
                }
                else if (guess < answer)
                {
                    WriteLine("Try a higher number.");
                }
                else if (guess > answer)
                {
                    WriteLine("Try a lower number.");
                }

            }
            catch (FormatException)
            {
                //WriteLine (e);
                WriteLine("That wasn't a number. Give me an actual number.");
            }
        }
        while(!success);
    }
}
