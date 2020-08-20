using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    public class ValidateString
    {
        public static string IsValid(Dictionary<char,int> dictionary)
        {
            if (FirstEvaluation(dictionary) | SecondEvaluation(dictionary) | ThirdEvaluation(dictionary))
            {
                return "YES";
            }
            
            return "NO";
        }

        private static bool FirstEvaluation(Dictionary<char,int> dictionary)
        {
            return dictionary.Values.Distinct().Count() == 1;
        }

        private static bool SecondEvaluation(Dictionary<char,int> dictionary)
        {
            var copyDictionary = new Dictionary<char, int>(dictionary);
            
            var keyOfMaxValue = copyDictionary.Aggregate((x,y) => x.Value > y.Value ? x:y).Key;
            copyDictionary[keyOfMaxValue]--;

            var answer = FirstEvaluation(copyDictionary);
            
            return answer;
        }

        private static bool ThirdEvaluation(Dictionary<char, int> dictionary)
        {
            var copyDictionary = new Dictionary<char, int>(dictionary);
            
            var keyOfMinValue = copyDictionary.Aggregate((x, y) => x.Value > y.Value ? y:x).Key;
            copyDictionary[keyOfMinValue]--;

            if (copyDictionary[keyOfMinValue] == 0)
            {
                copyDictionary.Remove(keyOfMinValue);
            }
            
            return FirstEvaluation(copyDictionary);
        }
    }
}