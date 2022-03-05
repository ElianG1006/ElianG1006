using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Bats", "Batman", "The Dark Knight", "Bruce Wayne" };

            //3 ways to convert the array to a list

            //1. use ToList on the array
            List<string> theBest = names.ToList();

            //2. pass the array to the List constructor
            List<string> batMen = new List<string>(names);

            //3. Loop over the array and copy each item to the list
            List<string> bats = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                bats.Add(names[i]);
            }

            //Cloning a List
            //what is NOT cloning?
            List<string> otherBats = bats; //NOT cloning. Both point to the same list of strings
            otherBats.Remove("Bruce Wayne");

            //1. use ToList on the List
            List<string> best2 = theBest.ToList();

            //2. pass the original list to the constructor
            List<string> batMens = new List<string>(batMen);
        }
    }
}
