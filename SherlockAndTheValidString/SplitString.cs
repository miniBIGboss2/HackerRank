using System.Collections.Generic;

namespace SherlockAndTheValidString
{
    public class SplitString
    {
        public static Dictionary<char, int> Split(string input)
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            
            foreach (char c in input)
            {
                if (!dictionary.TryAdd(c, 1))
                {
                    dictionary[c]++;
                }
            }
            
            return dictionary;
        }
    }
}