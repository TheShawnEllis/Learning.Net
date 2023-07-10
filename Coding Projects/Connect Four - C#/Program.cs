using System;
using System.Collections.Generic;
using static System.Console;

namespace ConnectFour;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.DisplayBoard();

        while (game.InProgress) 
        {
            game.SelectPosition();
        }
    }
}
