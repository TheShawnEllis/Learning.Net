using System;
using static System.Console;

namespace EnumsAndNullables;

class Program
{
    static void Main(string[] args)
    {
        WriteLine($"Monday = {ShiftDays.Monday}"); // Returns the string
        WriteLine($"Saturday value = {(int)ShiftDays.Saturday}"); // Casting will return the value 
        WriteLine($"Monday + Saturday = {((int)ShiftDays.Monday + (int)ShiftDays.Saturday)}"); // Values of the enum can have math operations done
        var days = ShiftDays.Sunday | ShiftDays.Monday;
        WriteLine($"Days = {days}");
    }
}
