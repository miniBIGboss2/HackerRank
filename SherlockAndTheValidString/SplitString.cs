using System;
using System.Collections.Generic;

namespace SherlockAndTheValidString
{
    public class SplitString
    {
        public static void Split(string input, Dictionary<char, int> dictionary)
        {
            foreach (char c in input)
            {
                try
                {
                    dictionary.Add(c, 1);
                }
                catch (ArgumentException)
                {
                    dictionary[c]++;
                }
            }
        }
    }
}