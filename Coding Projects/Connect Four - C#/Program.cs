using System;
using System.Collections.Generic;
using static System.Console;

namespace ConnectFour;

class Program
{
    static void Main(string[] args)
    {
        // Represent the board.
            //    1   2   3   4   5   6   7
            //  +---+---+---+---+---+---+---+
            //  |   |   |   |   |   |   |   |
            //  +---+---+---+---+---+---+---+
            //  |   |   |   |   |   |   |   |
            //  +---+---+---+---+---+---+---+
            //  |   |   |   |   |   |   |   |
            //  +---+---+---+---+---+---+---+
            //  |   |   |   |   |   |   |   |
            //  +---+---+---+---+---+---+---+
            //  |   |   |   |   |   |   |   |
            //  +---+---+---+---+---+---+---+
            //  | x |   |   |   |   | o |   |
            //  +---+---+---+---+---+---+---+

        GameBoard gameBoard = new GameBoard(); 
        gameBoard.DisplayBoard();
    }
}
