using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutationCheck
{
    /// <summary>
    /// Allows checking of two string are permutations of each other
    /// </summary>
    public class PermutationChecker
    {
        /// <summary>
        /// Checks if strings are permutations of each other.
        /// </summary>
        /// <param name="string1">string1 to check</param>
        /// <param name="string2">string2 to check</param>
        /// <returns>True if they are permutations, false if not</returns>
        public bool IsPermutation(string string1, string string2)
        {
            // first check if those strings are the same length
            if (string1.Length != string2.Length)
            {
                return false;
            }

            UniqueCharOccurenceCounter counter = new UniqueCharOccurenceCounter();

            // convert character occurence data to dictionary
            Dictionary<char, int> dictionary1 = counter.CountOccurencesAsDictionary(string1);
            Dictionary<char, int> dictionary2 = counter.CountOccurencesAsDictionary(string2);

            return compareDictionaries(dictionary1, dictionary2);
        }

        /// <summary>
        /// Compare two dictionaries
        /// </summary>
        /// <param name="dictionary1"></param>
        /// <param name="dictionary2"></param>
        /// <returns>true of both dictionaries had the same entries</returns>
        private bool compareDictionaries(Dictionary<char, int> dictionary1, Dictionary<char, int> dictionary2) 
        {
            char[] keysDict1 = dictionary1.Keys.ToArray();
            char[] keysDict2 = dictionary2.Keys.ToArray();

            try
            {
                foreach (char c in keysDict1)
                {
                    // different number of occurences of given character - strings are not permutations
                    if (dictionary1[c] != dictionary2[c])
                    {
                        return false;
                    }
                }
                return true;
            }
            // dictionary had character not contained in second one - strings are not permutations of each other
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
    }
}
