using static System.Console;

namespace CSharpExceptions;
class Program
{
    static void Main(string[] args)
    {
        // TODO: Exception Handling - TRY-CATCH
        // Technique for catching errors in code gracefully.
        int x = 10000;
        int y = 0;
        int result;

        try
        {
            if (x > 1000)
            {
                throw new ArgumentOutOfRangeException("x", "x has to be less than 1000 or equal"); // Best Practice: replace system error and give parameter causing error.
            }
            result = x / y;
            WriteLine("Result: {0}", result);
        }
        catch (DivideByZeroException e) // Catch specific error
        {
            WriteLine("Whoops!");
            WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e) // Catching error thrown allows the program to continue instead of exit.
        {
            WriteLine("Sorry, 1000 is the limit");
            WriteLine(e.Message);
        }
        finally // Code that always needs to run. Used for clearing or cleaning resources like open files.
        {
            WriteLine("This always runs");
        }
    }
}
