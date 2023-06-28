using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace ConnectFour
{
    public class GameBoard
    {
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
        
        /*
        private char[,] board = {
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
            {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+'},
        };
        */

        public GameBoard()
        {

        }

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

        public void SelectPosition(bool IsPlayerOneTurn)
        {
            int positionChoice;
            bool validChoice;
            char playerPiece;

            playerPiece = IsPlayerOneTurn ? 'x' : 'o';
            positionChoice = Read();
            validChoice = IsPositionChoiceValid(positionChoice);

            if (validChoice)
            {
                PlacePlayerPiece(positionChoice, playerPiece);
            }
        }


        public void PlacePlayerPiece(int SelectedPosition = 3, char BoardPiece = 'x')
        { 
            board[SelectedPosition,6] = BoardPiece;
        }

        /// <summary>
        /// For a player move to be valid:
        ///     Column selected must be 1-7. Selecting 0 or 8+ will give error.
        ///     A piece cannot be placed in same position another piece exists.
        ///     A piece cannot be placed in a column thats full.
        /// </summary>
        /// <param name="Column">Column selected by the user on current turn.</param>
        /// <returns></returns>
        public (bool, int) IsPositionChoiceValid(int SelectedColumn)
        {
            int nextOpenPosition = 0;

            try
            {
                // Check if column choice is between 1 and 7.
                if ((SelectedColumn > 1) && (SelectedColumn < 7))
                {
                    // TODO: board[row, col]
                    int rows = board.GetLength(1);
                    SelectedColumn -= 1;

                    // Check if column is full starting from bottom up                  
                    for (int i = 0; i < rows; i++)
                    {
                        int currentRow = rows - i;
                        char checkSpace = board[currentRow, SelectedColumn];

                        if (checkSpace == ' ')
                        {
                            nextOpenPosition = currentRow;
                            return (true, nextOpenPosition);
                        }
                    }
                    return (false, nextOpenPosition);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(SelectedColumn), "Invalid column selected. Choose a column from 1-7.");
                }                
            }
            catch(ArgumentOutOfRangeException ex)
            {
                WriteLine(ex);
                return (false, nextOpenPosition);
            }
            catch (Exception ex)
            {
                WriteLine(ex);
                return (false, nextOpenPosition);
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