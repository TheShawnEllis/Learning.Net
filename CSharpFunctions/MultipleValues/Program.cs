using System;
using static System.Console;

namespace MultipleValues;
class Program
{
    static void Main(string[] args)
    {
        // TODO: Tuples are grouped values 
        (int a, int b) tup1 = (5, 10); // Tuple with named elements
        var tup2 = ("Some text", 10.5f); // Tuple with no names. C# auto names Item[i]

        // TODO: Tuples are mutable
        tup1.a = 20;
        tup2.Item1 = "New Stringy string";
        WriteLine($"{tup1.a}, {tup1.b}");

        // TODO: Functions can work with tuples
        (int, int) result = PlusTimes(6, 12);
        WriteLine($"{result.Item1},  {result.Item2}");
    }

    // TODO: Functions can return multiple values using tuples
    static (int, int) PlusTimes(int a, int b)
    {
        return (a+b, a*b);
    }
}
