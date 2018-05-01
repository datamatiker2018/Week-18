using System;

namespace Week14Repetition.Iteration
{
    class Program
    {
        static void Main()
        {
            int[][] a = new int[][]
            {
                new[] { 1, 1, 2 },
                null,
                new[] { 21 },
                new[] { 34, 55 }
            };

            foreach (int[] subArray in a)
            {
                if (subArray != null)
                {
                    foreach (int n in subArray)
                    {
                        Console.Write($"{n} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
