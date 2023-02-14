using System;
using static System.Console;
using System.Globalization;

namespace Parsing;
class Program
{
    static void Main(string[] args)
    {
        string numStr1 = "1";
        string numStr2 = "2.00";
        string numStr3 = "3,000";
        string numStr4 = "3,000.00";

        // Parse function tries to parse a string in to a number
        // It may trhow exception so catch statement is needed
        int targetNum = 0;

        try 
        {
            // TODO: Parse Simple Integer
            targetNum = int.Parse(numStr1);
            WriteLine(targetNum);

            // TODO: Parse to a Floating Point (only works if decimal value is 0)
            targetNum = int.Parse(numStr2, NumberStyles.Float);
            WriteLine(targetNum);

            // TODO: Parse to a number with 1000s marker
                // NUmber styles "Allow.." sets what formatting is accepted
            targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
            WriteLine(targetNum);

            // TODO: Parse to a number with 1000s marker and decimal
            targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
            WriteLine(targetNum);

            // TODO: Parse with Bools
            WriteLine($"{bool.Parse("True")}");
            WriteLine($"{bool.Parse("False")}");

            // TODO: Parse Floating Point
            WriteLine($"{float.Parse("1.235"):F2}");

            // TODO: TRY.Parse checks if conversion works
            bool success = false;
            success = Int32.TryParse(numStr1, out targetNum);

            if (success)
            {
                WriteLine(targetNum);
            }

        }
        catch (Exception e)
        {
            WriteLine(e);
        }
    }
}
