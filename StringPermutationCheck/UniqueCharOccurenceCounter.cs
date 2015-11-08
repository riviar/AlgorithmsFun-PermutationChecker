using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutationCheck
{
    /// <summary>
    /// Maps character occurences in a string to dictionary
    /// </summary>
    public class UniqueCharOccurenceCounter
    {
        /// <summary>
        /// Calculates occurences of each unique char in string
        /// </summary>
        /// <param name="String">string</param>
        /// <returns>Dictionary in form CHAR/numberOfOccurences</returns>
        public Dictionary<char, int> CountOccurencesAsDictionary(string String)
        {
            char[] cutString = String.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int> { };

            foreach (char c in cutString)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }
            return dictionary;
        }
    }
}
