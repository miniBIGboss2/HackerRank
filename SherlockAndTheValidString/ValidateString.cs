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
            var keyOfMaxValue = dictionary.Aggregate((x,y) => x.Value > y.Value ? x:y).Key;
            dictionary[keyOfMaxValue]--;

            if (FirstEvaluation(dictionary))
            {
                dictionary[keyOfMaxValue]++;
                return true;
            }

            dictionary[keyOfMaxValue]++;
            return false;
        }

        private static bool ThirdEvaluation(Dictionary<char, int> dictionary)
        {
            var keyOfMinValue = dictionary.Aggregate((x, y) => x.Value > y.Value ? y:x).Key;
            dictionary[keyOfMinValue]--;

            if (dictionary[keyOfMinValue] == 0)
            {
                dictionary.Remove(keyOfMinValue);
            }
            
            return FirstEvaluation(dictionary);
        }
    }
}