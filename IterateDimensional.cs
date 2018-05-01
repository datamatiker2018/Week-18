using System;

namespace Week14Repetition.Iteration
{
    class Program
    {
        static void Main()
        {
            int[,] a = new int[,]
            {
                { 1, 1, 2, 3 },
                { 5, 8, 13, 21 },
                { 34, 55, 89, 144 }
            };

            int dimension1Length = a.GetLength(0);
            int dimension2Length = a.GetLength(1);
            
            
            for (int i = 0; i < dimension1Length; i++)
            {
                for (int j = 0; j < dimension2Length; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
