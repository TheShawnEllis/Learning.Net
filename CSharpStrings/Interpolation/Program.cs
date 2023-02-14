using System;
using static System.Console;

namespace Interpolation;
class Program
{
    static void Main(string[] args)
    {
        // Declaring variables
        string make = "Toyota";
        string model = "4Runner";
        int year = 2020;
        float miles = 8_450.27f;
        decimal price = 60_275.0m;

        // TODO: Output information using formatting
        WriteLine("This care is a {0} {1} {2}, with {3} miles and costs ${4}",
            year, make, model, miles, price);

        // TODO: Using a string interpolation
        Write($"This care is a {year} {make} {model}, with {miles} miles and costs {price:C2}");

        // TODO: Using expressions in string
        Write($"This care is a {year} {make} {model}, with {{{miles * 1.6:F2}}} km and costs {price:C2}");
    }
}
