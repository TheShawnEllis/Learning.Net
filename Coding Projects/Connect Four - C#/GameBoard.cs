using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using static System.Console;

namespace ConnectFour
{
    public class Game
    {
        public bool InProgress { get; set; }
        public int SpacesToWin { get; set; }

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
        private int rounds = 0;

        public Game()
        {
            InProgress = true;
            SpacesToWin = 5;
        }

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
            string? playerInput;
            char playerPiece = playerOneTurn ? 'x' : 'o';
            (bool valid, int openRow, int columnChoice) playerSelection;

            WriteLine(playerOneTurn ? "Player 1, choose column..." : "Player 2 choose column...");
            playerInput = ReadLine();
            playerSelection = IsPlayerChoiceValid(playerInput);

            if (playerSelection.valid)
            {
                if (playerOneTurn) rounds += 1;

                PlacePlayerPiece(playerSelection.openRow, playerSelection.columnChoice, playerPiece);
                playerOneTurn = !playerOneTurn;

                if (rounds >= SpacesToWin) IsGameWin(playerPiece);
            }
        }

        private void PlacePlayerPiece(int Row, int Column, char BoardPiece)
        {
            try
            {
                WriteLine($"Placing {BoardPiece} in Column {Column + 1}.");
                board[Row, Column] = BoardPiece;
                DisplayBoard();
            }
            catch (Exception ex)
            {
                WriteLine (ex.ToString());
            }            
        }

        private (bool, int, int) IsPlayerChoiceValid(string SelectedColumn)
        {
            try
            {   
                // Check player choice is not blank
                if (!string.IsNullOrWhiteSpace(SelectedColumn))
                {
                    // Check player choice is not a letter
                    if (Int32.TryParse(SelectedColumn, out int columnNumber))
                    {
                        int rows = board.GetUpperBound(0);
                        int cols = board.GetLength(1);

                        // Check if column exists
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

        private void IsGameWin(char Piece)
        {
            try
            {
                int openColumns = 0;
                int continuousPieces = 0;

                // Check for remaining moves using row 0
                for (int i = 0; i < board.GetUpperBound(1); i++)
                {
                    if (String.IsNullOrWhiteSpace(board[0, i].ToString()))
                    {
                        openColumns += 1;
                    }
                }

                if (openColumns == 0)
                {
                    InProgress = false;
                    WriteLine("\nNo more available moves. Game ends in tie.");
                }

                // Check horizonal win starting with lowest row
                for (int x = board.GetUpperBound(0); x >= 0; x--)
                {
                    continuousPieces = 0;

                    for (int y = 0; y < board.GetUpperBound(1); y++)
                    {
                        if (board[x, y] == Piece)
                        {
                            continuousPieces += 1;

                            if (continuousPieces >= SpacesToWin)
                            {
                                WriteLine($"Player {Piece} won the game!");
                                InProgress = false;
                                break;
                            }
                        }
                        else
                        {
                            continuousPieces = 0;
                        }    
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }
    }
}