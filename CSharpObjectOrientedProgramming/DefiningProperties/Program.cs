using System;
using static System.Console;

namespace DefiningProperties;
class Program
{
    static void Main(string[] args)
    {
        // Create new instance of Book
        Book b1 = new Book("A new learning book", "DeShawn E.", 825);

        // Access the properties
        WriteLine(b1.Name);
        WriteLine(b1.Description);

        // Set the auto generated properties
        b1.ISBN = "1534671531234856";
        b1.Price = 35.49m;
        WriteLine(b1.ISBN);
        WriteLine(b1.Price);

        // Change properties
        b1.Name = "Crimes by coding";
        b1.PageCount = 905;

        WriteLine(b1.Description);
    }
}
