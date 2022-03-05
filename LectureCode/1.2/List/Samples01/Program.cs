using System;
using System.Collections.Generic;

namespace Samples01
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays are zero-based indexes
            string[] names = new string[3] { "Bats", "Batman", "The Dark Knight" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            names[1] = names[1].ToUpper();

            //Lists are zero-based indexes
            List<string> best = new List<string>() { "Bats" };
            best.Add("Batman");
            best.Add("The Dark Knight");

            //Count vs Capacity
            List<int> numbers = new List<int>();
            Info(numbers);
            numbers.Add(1);//forces a resize of the internal array
            Info(numbers);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);//count: 4, capacity: 4
            numbers.Add(5);//forces a resize of the internal array
            Info(numbers);

            //Looping
            Console.WriteLine("-------FOR---------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-------FOREACH---------");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        private static void Info(List<int> nums)
        {
            Console.WriteLine($"Count: {nums.Count}\tCapacity: {nums.Capacity}");
        }
    }
}
