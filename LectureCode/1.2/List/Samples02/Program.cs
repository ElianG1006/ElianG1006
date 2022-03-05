using System;
using System.Collections.Generic;

namespace Samples02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 1, 5, 6, 7 };
            //There are 2 ways to remove items: Remove(item) or RemoveAt(index)
            Print(numbers);
            numbers.Remove(1);//this will remove the first 1 it finds
            Print(numbers);

            numbers.RemoveAt(2);
            Print(numbers);
        }

        private static void Print(List<int> nums)
        {
            Console.Write("\n[");
            bool isFirst = true;
            foreach (var item in nums)
            {
                if (!isFirst) Console.Write(", ");
                Console.Write(item);
                isFirst = false;
            }
            Console.WriteLine("]");
        }
    }
}
