using System;
using static System.Console;


namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("War and Stuff", "Lea Fritz", 852, 40.45m);
        Magazine m1 = new Magazine("Time", "Time USA", 80, 4.67m);

        WriteLine($"{b1.Name}, {b1.Author}");
        WriteLine($"{m1.Name}, {m1.Publisher}");

        // Property validation will prevent empty name
        // b1.Name = "";

        // Call override functions 
        WriteLine(b1.GetDescription());
        WriteLine(b1.Price);
        WriteLine(m1.GetDescription());
        WriteLine(m1.Price);
    }
}
