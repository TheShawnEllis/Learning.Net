﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace ConnectFour;

class Program
{
    static void Main(string[] args)
    {
        GameBoard gameBoard = new GameBoard(); 
        gameBoard.DisplayBoard();
    }
}