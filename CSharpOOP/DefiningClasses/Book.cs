using System;

// C# Namespaces are used to organize classes and code elements in a program
    // Its used to create unique types and reduce name conflicts
    // Namespaces are declared with the "namespace" keyword, the name, then a block of code.
    // Namespaces can contain other namespaces, classes, and code
namespace DefiningClasses
{
    // Classes have unique names within the name space.
    public class Book
    {
        // TODO: Classes have member variables, or "fields" that hold data
        string _name;
        string _author;
        int _pagecount;
        
        // TODO: Classes have 1 or more constructors
            // A Constructor is a function used to create a class of this type
        public Book(string Name, string Author, int Pages)
        {
            _name = Name;
            _author = Author;
            _pagecount = Pages;
        }

        // TODO: Methods are used to operate on teh class and data
        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}