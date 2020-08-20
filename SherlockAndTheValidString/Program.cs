using System;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            
            var dictionary = SplitString.Split(input);
            
            var answer = ValidateString.IsValid(dictionary);
            
            Console.WriteLine(answer);
        }
    }
}