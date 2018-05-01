using System;
using System.Collections.Generic;

namespace Week14Repetition.Practice
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();
            Minefield minefield = new Minefield(10, 10); // Static size minefield

            // We know the dimensions of the minefield
            int numberOfFields = minefield.Width * minefield.Height;
            // We want between 1/4 and 1/2 of the field filled with mines
            int numberOfMines = rng.Next(numberOfFields / 4, numberOfFields / 2);

            for (int i = 0; i < numberOfMines; i++)
            {
                while (!minefield.PlaceMine(rng.Next(minefield.Height), rng.Next(minefield.Width)))
                {
                    // We use the while loop + PlaceMine return type to ensure that every placement is unique
                    // This is a bit ugly, but it does the job well enough
                }
            }
            
            minefield.Print();
        }
    }

    class Minefield
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int[,] _hints;
        private readonly List<(int, int)> _mines = new List<(int, int)>();

        public Minefield(int width, int height)
        {
            _width = width;
            _height = height;
            _hints = new int[height, width];
        }

        // The "arrow" syntax is like only defining a getter in one line
        public int Width => _width;
        public int Height => _height;

        public bool PlaceMine(int row, int column)
        {
            // Check if out of bounds
            if ((row < 0 || row > _height - 1) && (column < 0 || column > _width - 1))
            {
                return false;
            }
            
            (int, int) mine = (row, column);

            // Check if mine is already placed in this position
            if (_mines.Contains(mine))
            {
                return false;
            }
            
            _mines.Add(mine);

            // Bounds checking!
            int rowStart = Math.Max(row - 1, 0); // If row == 0
            int rowEnd = Math.Min(row + 1, _height - 1); // If row == _height - 1
            int columnStart = Math.Max(column - 1, 0); // If column == 0
            int columnEnd = Math.Min(column + 1, _width - 1); // If column == _width - 1 
            
            for (int i = rowStart; i <= rowEnd; i++)
            {
                for (int j = columnStart; j <= columnEnd; j++)
                {
                    _hints[i, j]++;
                }
            }

            return true;
        }

        public void Print()
        {
            for (int row = 0; row < _height; row++)
            {
                for (int column = 0; column < _width; column++)
                {
                    if (_mines.Contains((row, column)))
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(_hints[row, column]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
