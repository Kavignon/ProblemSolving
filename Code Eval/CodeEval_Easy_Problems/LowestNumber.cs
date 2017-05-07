using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy_Problems
{
    public static class LowestNumber
    {
        public static int FindLowestUniqueNumberPosition(string serieOfNumbers)
        {
            var values = serieOfNumbers.Split(' ').Select(int.Parse).ToList();
            var minValue = values.Distinct().Min();
            return values.IndexOf(minValue);
        }

        public static int LowestUniqueIndex(string serieOfNumbers)
        {
            var values = serieOfNumbers.Split(' ').Select(int.Parse).ToList();
            var singleValues = values.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).ToList();
            return (singleValues.Count > 0)? (1 + values.Select((v, i) => new { v, i }).First(x => x.v == singleValues.Min()).i) : 0;
        }
    }
}