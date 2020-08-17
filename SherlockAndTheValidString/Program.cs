using System;
using System.Collections.Generic;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main()
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            string input = Console.ReadLine();
            SplitString.Split(input, dictionary);
            Console.WriteLine(ValidateString.IsValid(dictionary));
        }
    }
}