using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutationCheck
{
    /// <summary>
    /// Simple program for checking of two string are permutations of each other.
    /// Works by counting occurences of characters and mapping them to dictionaries.
    /// Resulting dictionaries are then compared with each other.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // I really do hurt on the inside for calling variables this way, but there is no way to tell more about them
            // ask user for typing in the strings
            Console.WriteLine("Please type in first string");
            string stringOne = Console.ReadLine();
            Console.WriteLine("Please type in second string");
            string stringTwo = Console.ReadLine();

            // check if those string are permutations of each other
            PermutationChecker permChecker = new PermutationChecker();
            bool isPermutation = permChecker.IsPermutation(stringOne, stringTwo);

            // display answer
            Console.WriteLine("Those strings " + (isPermutation ? "are" : "aren\'t") + " permutations.");
            Console.ReadLine();
        }
    }
}
