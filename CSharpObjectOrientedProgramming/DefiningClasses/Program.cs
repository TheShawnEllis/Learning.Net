using System;
using static System.Console;

namespace DefiningClasses;
class Program
{
    static void Main(string[] args)
    {
        // TODO: Create new object instance using the "new" operator
        Book b1 = new Book("War", "Leo Dude", 825);
        Book b2 = new Book("Peace", "John Stein", 464);

        // TODO: Call a method on the object
        WriteLine(b1.GetDescription());
        WriteLine(b2.GetDescription());

        // TODO: Attempting to set one of the members/fields (properties) directly will give error.
        // b1._name = "De";  
        // b1.Name = "De";
    }
}
