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
    
        //public void PlacePlayerPiece()
        //{
        //    board[0,1] = 'x';
        //    board[3,6] = 'o';
        //}

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

        public void SelectPosition()
        {
            // Get value from the user
            // Check if position is valid 
            // Place piece
        }

        /// <summary>
        /// For a player move to be valid:
        ///     Column selected must be 1-7. Selecting 0 or 8+ will give error
        ///     A piece cannot be placed in same position another piece exists
        ///     A piece cannot be placed in a column thats full.
        /// </summary>
        /// <param name="Column">Column selected by the user on current turn.</param>
        /// <returns></returns>
        public bool PlacePlayerPiece(int SelectedColumn, char PlayerPiece)
        {
            bool valid = true;
            int rows = board.GetLength(1);

            try
            {
                // User will use 1-7, converting to index
                SelectedColumn -= 1;

                // Check if column choice is between 1 and 7.
                if ((SelectedColumn > 1) && (SelectedColumn < 7))
                {
                    // check the column of the lowest row first if space is open
                    // If not open check next lowest
                    // If open place piece
                    for (int i = 0; i < rows; i++)
                    {
                        char checkPosition = board[rows - 1, SelectedColumn];
                        
                        if (checkPosition == ' ')
                        {
                            checkPosition = PlayerPiece;
                            break;
                        }
                    }
                }
                else
                {
                    valid = false;
                    throw new ArgumentOutOfRangeException(nameof(SelectedColumn), "Invalid column selected. Choose a column from 1-7.");
                }                
            }
            catch(ArgumentOutOfRangeException ex)
            {
                WriteLine(ex);
                SelectPosition();
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
            return valid;
        }
    }
}