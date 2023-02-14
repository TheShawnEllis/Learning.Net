using System;
using static System.Console;

namespace Formatting;
class Program
{
    static void Main(string[] args)
    {
        // string outStr;
        // string str1 = "The quick brown fox was brown.";
        // string str2 = "This is a string";
        // string str3 = "THIS is a STRING";
        // string[] strArray = {"one", "two", "three", "four"};

        int[] quarters = {1, 2, 3, 4};
        int[] sales = {100000, 150000, 200000, 225000};
        double[] intlMixPct = {.386, .413, .421, .457};
        string str1 = "TestStr";
        int val1 = 1234;
        decimal val2 = 1234.5678m;

        // TODO: Basic Sting Formmating Infomation
        WriteLine("{0}", str1);

        // TODO: Specifying Numerical Formatting
            /*  General format is {indes[,alignment]:[format]}
                Common types are:
                    N = Number
                    G = General
                    F = Fixed Point
                    E = Exponential
                    D = Decimal
                    P = Percent
                    X = Hexidecimal
                    C = Currency
            */
        Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
        Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

        // TODO: Specifing the precision of a number
            // {index:formatting[precision]}
        Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

        // TODO: Formatting{ the alignment and spacing
            // {index,spacing:format}
        Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",
            quarters[0], quarters[1], quarters[2], quarters[3]);








    }
}
