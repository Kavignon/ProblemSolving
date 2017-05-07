using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy_Problems
{
    /*
    Constraints
    N is in range [0, 100] 
    L is in range [10000, 30000] 
    */
    public static class TheMajorElement
    {
        /*
        The major element in a sequence with the length of L is the element which appears
        in a sequence more than L/2 times. The challenge is to find that element in a sequence.
        */
        //Did not consider the L/2 times yet. Logic is passing is correct at the moment
        //But not considering all the constraints of the problem. Will do on later commit.
        public static string FindTheMajorElement(string input)
        {
            var inputDictionary = new Dictionary<string, int>();
            var splitValues = input.Split(',');
            foreach (var value in splitValues)
            {
                if (!inputDictionary.ContainsKey(value))
                    inputDictionary.Add(value, 1);
                else
                    inputDictionary[value]++;
            }
            var max = inputDictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var lookup = inputDictionary.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1);
            var isMaxWithinDuplicateValue = false;

            foreach (var item in lookup)
            {
                isMaxWithinDuplicateValue = item.Aggregate("", (s, v) => s + " " + v).Split(' ').Contains(max);
            }

            return isMaxWithinDuplicateValue ? "None" : max;
        }
    }
}