using System;
using static System.Console;


namespace StringOperations;
class Program
{
    static void Main(string[] args)
    {
        // NOTES:
        // Strings are sequences of characters. Similar properties to an array.
        // This allow a string char to be called like an item in an array.
        // Strings can be iterated over.

        string outStr;
        string str1 = "The quick brown fox was brown.";
        string str2 = "This is a string";
        string str3 = "THIS is a STRING";
        string[] strs = {"one", "two", "three", "four"};

        // TODO: Get lenth of a string
        WriteLine("Lenth of str1 is : {0}",str1.Length);

        // TODO: Access individual characters in a string
        WriteLine("The 14th character in str1 is: {0}", str1[14]);

        // TODO: Iterate over a string
        foreach (char ch in str1)
        {
            Write(ch);
            if (ch == 'b')
            {
                WriteLine();
                break;
            }
        }

        // TODO: Concatenate strings
        outStr = String.Concat(strs);
        WriteLine(outStr);

        // TODO: Joining strings
        outStr = String.Join('.', strs);
        WriteLine(outStr);

        // TODO: Comparing Strings
        // Compare will perform an ordinal comparision and return:
            // < 0 : first string comes before the second in sorting order
            // 0 : first and second string are in same position sorting order
            // > 0 : first string comes after second string in sorting 
        WriteLine("Comparing Strings:");
        int strSortResult = String.Compare(str2, "This is a string");
        WriteLine(strSortResult);

        // TODO: Compare if string is equal
            // string.Equals returns boolean
        bool isStrEqual = str2.Equals(str3);

        // TODO: String Searching
        // IndexOf: Returns 0 based index of the first instance found in the string
        WriteLine(str1.IndexOf('e'));
        WriteLine(str2.IndexOf("fox"));

        // LastIndexOf: Returns 0 based index of the last instance found in the string
        WriteLine(str1.LastIndexOf('e'));
        WriteLine(str2.LastIndexOf("the"));

        // Replace: Replaces the instances found in the string with the values passed 
        string outstr = str1.Replace("fox", "cat");
        Console.WriteLine(outstr);
        WriteLine(outstr.IndexOf("fox"));
    }
}
