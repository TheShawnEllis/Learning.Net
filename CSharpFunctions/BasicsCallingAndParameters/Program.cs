using System;
using static System.Console;

// Functions are used to group and reuse code in a single unit
// and to be customized with parameters.


// TODO: Functions have a return type, name, optional parameters
float MilesToKm(float miles)
{
    float result = miles * 1.6f;
    return result;
}

// TODO: Funtions with no return value has a 'void' type
void PrintWithPrefix(string TheStr)
{
    WriteLine($"::> {TheStr}");
}

// TODO: Functions with default value for parameter
void PrintPrefixWithDefault(string Message, string Prefix = "::>")
{
    WriteLine($"{Prefix} {Message}");
}



// TODO: Call a function
WriteLine($"The result is: {MilesToKm(35.89f)}");
PrintWithPrefix("Test String");

// TODO: Call function that has default parameter value
PrintPrefixWithDefault("My message yo!");
PrintPrefixWithDefault("My message yo!","Temp");

// TODO: Call function with named parameters:
    // useful when order of parameters passed is changed
    // Increases readability also
PrintPrefixWithDefault(Prefix: "^^^", Message: "Second message!");

