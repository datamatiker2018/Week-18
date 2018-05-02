using System;

namespace Week14Repetition.Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 1, 2, 3, 5 };
    
            //PrintArray(array, true, "ChangeA");
            ChangeA(array);
            //PrintArray(array, false, "ChangeA");
            //PrintArray(array, true, "ChangeB");
            ChangeB(array);
            //PrintArray(array, false, "ChangeB");
            //PrintArray(array, true, "ChangeC");
            ChangeC(array);
            //PrintArray(array, false, "ChangeC");
            //PrintArray(array, true, "ChangeD");
            ChangeD(array);
            //PrintArray(array, false, "ChangeD");
        }
    
        public static void ChangeA(int[] array)
        {
            array[3] = 24;
        }
    
        public static void ChangeB(int[] array)
        {
            int[] myArray = array;
    
            myArray[4] = 42;
        }
    
        public static void ChangeC(int[] array)
        {
            array[0] = array[2];
        }
        
        public static void ChangeD(int[] array)
        {
            array = new int[5];
        }
        
        // Ignore this method
        public static void PrintArray(int[] array, bool before, string method)
        {
            Console.WriteLine(
                    "{0} {1}: [{2}]", 
                    method, 
                    before ? "before" :"after", 
                    string.Join(", ", array)
            );
        }
    }
}
