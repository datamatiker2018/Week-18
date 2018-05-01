using System;
using System.Collections.Generic;

namespace Week14Repetition.Iteration
{
    class Program
    {
        static void Main()
        {
            List<int> a = new List<int>() { 1, 1, 2, 3 };

            for (int i = 0; i < a.Count; i++)
            {
                Console.Write($"{a[i]} ");
            }

            Console.WriteLine();

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }
                
                a.Add(input);
            }

            foreach (int n in a)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine();

            if (a.Contains(5))
            {
                Console.WriteLine("a does contains a 5");
            }
            else
            {
                Console.WriteLine("a does not contain a 5");
            }

            Console.WriteLine($"first = {a.IndexOf(3)}, last = {a.LastIndexOf(3)}");

            while (a.Remove(1))
            {
                Console.WriteLine("Removed a 1");
            }
            
            Console.WriteLine(string.Join(", ", a));
            
            a.RemoveAt(0);

            Console.WriteLine(string.Join(", ", a));
            
            a.RemoveAt(a.Count - 1);
            
            Console.WriteLine(string.Join(", ", a));
            
            a.Sort();
            
            Console.WriteLine(string.Join(", ", a));
            
            a.Clear();
            
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
