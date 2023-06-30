using System;
using System.Text;
using static System.Console;

namespace Builder;
class Program
{
    static void Main(string[] args)
    {
        int jumpCount = 10;
        string[] animals = {"goats", "cats", "pigs"};

        // TODO: Create StringBuilder (initial string, max character)
        StringBuilder sb = new StringBuilder("Initial String", 200);

        // TODO: Basic string builder stats
        WriteLine($"Capacity: {sb.Capacity}; Lenght: {sb.Length}");

        // TODO: Add strings using Append strings
        sb.Append("The quick ");
        sb.Append("brown fox.");

        // TODO: Append a line ending
        sb.AppendLine();

        // TODO: Append formatted string
        sb.AppendFormat($"He jumped {jumpCount}");
    }
}
