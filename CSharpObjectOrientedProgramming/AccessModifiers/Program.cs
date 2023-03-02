using System;
using static System.Console;

namespace AccessModifiers;

class Program
{
    static void Main(string[] args)
    {   
        // NOTES: 
        // Access modifiers: Keywords that allow control over how the code
        // and data in class definitions are exposed to other parts of the program.
            // public - Methods or class member can be access by any other code in the program
            // protected - Methods or class members can be accessed only by code in the class or subclass
            // private - Method or class members can only be accessed by code withing the class definition
        

        // Create new instance of Book 
        Book b1 = new Book("War", "Leo Dude", 825);

        // In previous example this code would fail because by default it was set to private
        // This is bad to do because of type coupling in the code
        b1._name = "De";  
        WriteLine(b1.GetDescription());

        // TODO: Set data using functions instead of accessing the fields directly
        b1.SetAuthor("DeShawn E.");
        b1.SetName("Learning C# the Hard Way");
        b1.SetPages(346);

        WriteLine(b1.GetDescription());

    }
}
