using System;
using System.Collections.Generic;

namespace Week14Repetition.Practice
{
    class Program
    {
        static void Main()
        {
            char[,] board = {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
            };

            for (int i = 0; i < 9; i++)
            {
                char player;

                if (i % 2 == 0)
                {
                    player = 'X';
                }
                else
                {
                    player = 'O';
                }

                Console.WriteLine($"{player}'s turn");

                // Bug: if row or column is not between 0 and 8, an IndexOutOfRangeException occurs
                Console.Write("Row: ");
                
                int row = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Column: ");
                int column = Convert.ToInt32(Console.ReadLine());

                // Bug: if the position on the board is already occupied, it's overwritten
                board[row, column] = player;

                PrintBoard(board);

                if (CheckWin(board))
                {
                    Console.WriteLine($"{player} won!");
                    return;
                }
            }

            Console.WriteLine("It's a draw!");
        }

        private static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static bool CheckWin(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                // Horizontal
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }

                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
            }

            // Diagonal left-right
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            
            // Diagonal right-left
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            return false;
        }
    }
}
