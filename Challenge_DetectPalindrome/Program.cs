using System;
using static System.Console;
using System.Text;

namespace Challenge_DetectPalindrome;
class Program
{
    static void Main(string[] args)
    {
        // Palindrome: words that are spelled the same backwards and forward
        //Requirements: 
            // Reads input and determine if palindrome
            // Ignore punctuations, spaces, and case
            // Function must be named IsPalindrome
                // Return 2 values: boolean and integer
            // Runs until exit is given
        
        bool keepPlaying = true;
        string playAgainResponse;

        do
        {   
            WriteLine("Enter some text to see if its a palindrome:");
            IsPalindrome(ReadLine());

            WriteLine("Play again? Use no or exit.");
            playAgainResponse = ReadLine().ToLower();
            if (playAgainResponse == "exit" || playAgainResponse == "no") keepPlaying = false;
        }
        while(keepPlaying);
    }

    static (bool, int) IsPalindrome(string UserInput) 
    {
        // Strip whitespace and case
        string cleanInput = UserInput.ToLower().Replace(" ", "");

        // Strip punctuation
        StringBuilder sb = new StringBuilder();
        foreach (char c in cleanInput)
        {
            // Add only characters that are not punctuations
            if (!char.IsPunctuation(c))
            {
                sb.Append(c);
            }
        }

        cleanInput = sb.ToString();

        // Validate if palidrome
        for(int i = 0; i < cleanInput.Length; i++)
        {
            int c = cleanInput.Length - i;
            if (cleanInput[i] != cleanInput[c])
            {
                WriteLine("Not a palidrome");
                return (false, cleanInput.Length);
            }
            Write(cleanInput[i]);
        }
        WriteLine("This is a palidrome.");
        return (true, cleanInput.Length);
    }
}
