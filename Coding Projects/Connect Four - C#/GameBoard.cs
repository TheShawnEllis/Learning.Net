using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using static System.Console;

namespace ConnectFour
{
    public class Game
    {
        // Notes: board[row, column]
        // Representing the board as a 2D array.
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
        
        private char[,] board = {
            {' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' '}            
        };
        private string colSeperator = "| ";
        private string rowBoarder = "+---+---+---+---+---+---+---+";
        private bool playerOneTurn = true;

        public void DisplayBoard() 
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            // Print Header row
            for (int i = 0; i < cols; i++)
            {
                Write($"{colSeperator}{i + 1} ");
            }
            Write(colSeperator);
            WriteLine();
            WriteLine(rowBoarder);

            // Print game board
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {   
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    Write($"{colSeperator}{board[currentRow, currentCol]} ");
                }
                Write(colSeperator);
                WriteLine();
                WriteLine(rowBoarder);
            }
            WriteLine();
        }

        public void SelectPosition()
        {
            string? playerInput;
            char playerPiece = playerOneTurn ? 'x' : 'o';
            (bool valid, int openRow, int columnChoice) playerSelection;

            WriteLine(playerOneTurn ? "Player 1, choose column..." : "Player 2 choose column...");
            playerInput = ReadLine();
            playerSelection = IsPlayerChoiceValid(playerInput);

            if (playerSelection.valid)
            {
                PlacePlayerPiece(playerSelection.openRow, playerSelection.columnChoice, playerPiece);
                playerOneTurn = !playerOneTurn;
            }
            else SelectPosition();
        }

        public void PlacePlayerPiece(int Row, int Column, char BoardPiece)
        {
            try
            {
                WriteLine($"Placing {BoardPiece} in Column {Column + 1}.");
                board[Row, Column] = BoardPiece;
            }
            catch (Exception ex)
            {
                WriteLine (ex.ToString());
            }
            
        }

        public (bool, int, int) IsPlayerChoiceValid(string SelectedColumn)
        {
            // TODO: Fix column 0 showing full when open
            try
            {
                if (!string.IsNullOrWhiteSpace(SelectedColumn))
                {
                    if (Int32.TryParse(SelectedColumn, out int columnNumber))
                    {
                        int rows = board.GetUpperBound(0);
                        int cols = board.GetLength(1);

                        if ((columnNumber >= 1) && (columnNumber <= cols))
                        {
                            columnNumber -= 1;

                            for (
                                int row = 0; row <= rows; row++)
                            {
                                int checkRow = rows - row;
                                if (board[checkRow, columnNumber] == ' ')
                                {
                                    return (true, checkRow, columnNumber);
                                }
                            }
                            
                            WriteLine($"Column {SelectedColumn} if full. Choose another column.");
                            return (false, 0, 0);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid column selected. Choose a column between 1 - {cols}");
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Column selection must be a number.");
                    }
                }
                else
                {
                    throw new ArgumentException("Player selection cannot be blank.");
                }                
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                return (false, 0, 0);
            }
        }

        public void ClearBoard()
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int currentrow = 0; currentrow < rows; currentrow++)
            {
                for (int currentcol = 0; currentcol < cols; currentcol++)
                {
                    board[currentrow, currentcol] = ' ';
                }
                WriteLine();
            }
        }
    }
}