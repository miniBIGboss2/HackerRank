using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    public class SplitString
    {
        public static Dictionary<char, int> Split(string input)
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            
            foreach (var c in input.Where(c => !dictionary.TryAdd(c, 1)))
            {
                dictionary[c]++;
            }
            
            return dictionary;
        }
    }
}