using System;
using System.Collections.Generic;

namespace Week14Repetition.Iteration
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, string> a = new Dictionary<char, string>()
            {
                { 'a', "Alpha" },
                { 'b', "Beta" },
                { 'c', "Charlie" },
                { 'd', "Delta" }
            };

            foreach (KeyValuePair<char,string> entry in a)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            while (true)
            {
                char key = Console.ReadKey().KeyChar;

                if (key == ' ')
                {
                    break;
                }

                string value = Console.ReadLine();
                
                a.Add(key, value);
            }

            Console.WriteLine();

            foreach (KeyValuePair<char,string> entry in a)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            if (a.ContainsKey('e'))
            {
                Console.WriteLine("a does contain an entry with the key a");
            }
            else
            {
                Console.WriteLine("a does not contain an entry with the key a");
            }

            if (a.ContainsValue("Charlie"))
            {
                Console.WriteLine("a does contain an entry with the value Charlie");
            }
            else
            {
                Console.WriteLine("a does contain an entry with the value Charlie");
            }

            if (a.TryGetValue('f', out string v))
            {
                Console.WriteLine(v);
            }
            else
            {
                Console.WriteLine("a does not contain an entry with the key f");
            }

            a.Remove('a');
        }
    }
}
