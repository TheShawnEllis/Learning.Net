namespace CSharpLearning;
class Program
{
    /// XML comments are used to provide documentation of the code
    /// <summary>
    ///     This is the main application for learning C# and using working examples. 
    /// </summary>
    /// <param name="args">
    ///     An arrary of string arguments from the command line
    /// </param>
    /// <returns>
    ///     No return value
    /// </returns>
    /// <see href='https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags'>
    ///     XML tags for C# documentation comments
    /// </see>
    static void Main(string[] args)
    {
        // TODO: Declaring & initializing variables
        int myNum = 13;
        string myString = "This is a string!";
        bool myBool = false;
        var myDynamicVariable = "Some text";
        char myChar = 'A';
        float myFloat = 2.45f;
        decimal myDecimal = 2.0M;

        // TODO: Declaring an array 
        int[] myNumArray = new int[5];
        myNumArray[0] = 13;

        string[] myStringArray = {"one", "two", "three", "four", "five"};
        
        bool[] myBoolArray = new bool[3];
        myBoolArray.Append(true);
        myBoolArray.Append(false);
        myBoolArray.Append(true);

        // TODO: Implicit conversion between types
        long bigNum;
        int myInt = 32;
        bigNum = myInt;

        // TODO: Explicit conversion of types
        float intToFloat = (float)myInt;
        Console.WriteLine(intToFloat);

        int floatToint = (int)myFloat;
        Console.WriteLine(myFloat);
        Console.WriteLine(floatToint);

        // TODO: Concatenate Strings
        string str1 = "Hello";
        string str2 = " ";
        string str3 = "World";

        Console.WriteLine(str1 + str2 + str3);

        // TODO: Arithmetic operators
        // Arithmetic operations peform math calculations (+, -, /, *, %)
        int a = 5;
        int b = 10;
        int c = 15;
        Console.WriteLine(a + b + c);

        // Math operations can be performed on a string too.
        string numStr = "123";
        int newInt = 45;
        Console.WriteLine(numStr + newInt);

        // Increment and decrement
        int counter = 0;
        Console.WriteLine($"Start Increment counter: {counter}");
        Console.WriteLine($"Counter++: {counter++}"); // Value = 0, Outputs value then increments
        Console.WriteLine($"++Counter: {++counter}"); // Value = 2, Increments then outputs the value
        Console.WriteLine($"Counter--: {counter--}"); // Value = 2, Outputs the value then decrements
        Console.WriteLine($"--Counter: {--counter}"); // Value = 0, Decrements the value then output

        // TODO: Logical operators
        // Logical operators check if an expression is true ( &&, ||, &, |, !)
        
        // ! = Logical negation - produces true if the evaluation is false (reverse)
        bool passed = false;
        Console.Write(!passed); // Output is True
        Console.Write(!true); // Output is False

        // & = Computes the the logical AND of its operands (evaluates both operands left and right)
        // && = Computes the logical AND of its operands (doesnt evlaute right operand if left operand if false)
        bool firstBool = true;
        bool secondBool = false;
        bool thirdBool = false;
        Console.WriteLine(firstBool & secondBool); // Outputs false
        Console.WriteLine(secondBool & thirdBool); // Outputs true

        // ^ = Exclusive OR (XOR) = Evalutes to true if one and only one of the operands is true
        Console.WriteLine(true ^ true); // False
        Console.WriteLine(true ^ false); // True
        Console.WriteLine(false ^ true); // True
        Console.WriteLine(false ^ false); // False

        // | = OR operator computes true if either of the operands evalute to true (evalutates both operands)
        // || = OR operator computes true if either operand is true (doesnt evalute right if left is false)
        Console.WriteLine(true | false);  // True
        Console.WriteLine(true | true);   // True
        Console.WriteLine(false | false); // False

              
        // TODO: Null-coalescing operators
        // The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; 
        // Otherwise, it evaluates the right-hand operand and returns its result.
        Console.WriteLine(str1 ?? "Unknown");

        // TODO: Commenting 
        // Two forslashes is a single line comment.
        
        /* 
            ------ 
            Multiline comments starts with a slash and star
            And then to end the multi line comment use the revers, star then slash
            ------
        */

        /// XML Comment are used for providing documentation of the code.
        /// Check the comment above Main for XML comments
        
        // TODO: Build code documentation
        // Add <GenerateDocumentationFile>true</GenerateDocumentationFile> in the .csproj file
        // Add <DocumentationFile> location for the documentation file.

        // TODO: IF ELSE statements
        int myVal = 13;
        if (myVal > 15)
        {
            Console.WriteLine("This was true");
        }
        else
        {
            Console.WriteLine("Nope, its false.");
        }

        // Ternary operator for if else statement
        Console.WriteLine(myVal > 15 ? "This was true" : "Nope, its false.");

        // TODO: Switch statement
        switch (myVal)
        {
            case 50:
                Console.WriteLine("50");
                break;
            case 15:
                Console.WriteLine("50");
                break;
            case 51:
            case 52:
                Console.WriteLine("51 or 52");
                break;
            default:
                Console.WriteLine("nothing matched...");
                break;
        }


        // FOR loops
        // Loops a block of code a specific number of times
        // Needs iterator, condition, incremtor
        for (int i = 0; i < myVal; i++)
        {
            Console.WriteLine("i = {0}", i);
        }

        // FOREACH loop
        // Loops a block of code for the number of items in a collections or secuence
        foreach (int thing in myNumArray)
        {
            Console.WriteLine("i = {0}", thing);
        }

        // TODO: Loop for a counter. 
        string myStr = "This is a string.";
        int count = 0;
        foreach (char letter in myStr)
        {
            if (letter == 's') count++;
        }
        Console.WriteLine($"There are {count} 's' in the string.");

        // TODO: WHILE loop
        // Loop a block of code until evaluated condition is false
        string inputStr = "";
        Console.WriteLine("Do-While Loop");
        while (inputStr != "exit")
        {
            inputStr = Console.ReadLine();
            Console.WriteLine($"You entered: {inputStr}");
        }

        // TODO: DO-WHILE loop
        // Loop that executes the block of code at least once then continues if evaluted to true. 
        Console.WriteLine("Do-While Loop");
        do
        {
            inputStr = Console.ReadLine();
            Console.WriteLine($"You entered: {inputStr}");
        }
        while(inputStr != "exit");
    }   
}
