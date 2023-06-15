using System;
using static System.Console;

namespace EnumsAndNullables;

class Program
{
    static void Main(string[] args)
    {
        // ENUMS
        // Enums provide a constrained set of values that can be chosen from. 
        // Values will be auto assigned unless manually done. Values are assigned in sequence

        // Returns the name as a string
        WriteLine($"Monday = {ShiftDays.Monday}");

        // Casting an enum will return the value
        WriteLine($"Saturday value = {(int)ShiftDays.Saturday}");  
        
        // Values of the enum can have math operations done
        WriteLine($"Monday + Saturday = {((int)ShiftDays.Monday + (int)ShiftDays.Saturday)}"); 

        // By default when having more than one option for the enum the values will be added instead of showing two option.
        // The [Flags] attribute will allow the options to be outputted individually.
        var days = ShiftDays.Sunday | ShiftDays.Monday; 
        WriteLine($"Days = {days}");

        // Testin for enums
        bool availableSunday = days.HasFlag(ShiftDays.Sunday);
        WriteLine(availableSunday);

        // List of all options can be retrieved by passing the enum type
        // Great for using in dropdowns.
        var shiftNames = Enum.GetNames(typeof(ShiftDays));
        WriteLine(String.Join(' ', shiftNames));


        // Nullable Types
        string input = null;
        int definiteInt;
        int? age = null; // ? makes a int nullable
        Nullable<int> age2 = null; // another way to write it as a generic

        // Using the null coalescing you can assin a null type to another variable by checking first if it has a value.
        // ?? checks if a null has a value first.        
        age ??= 12; // Will assign 12 if age is null
        definiteInt = age ?? 17; // Says if null assign 17;

        if (age != null)
        {
            WriteLine($"Age is {age}");
        }

        // Nullable of a types has additional properties like checking for a value. 
        if (age.HasValue) 
        {
            WriteLine(age.Value);
        } 
    }
}
