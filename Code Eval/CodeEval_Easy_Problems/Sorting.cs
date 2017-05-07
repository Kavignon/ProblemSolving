using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    public static class Sorting
    {
        //Print sorted numbers in the following way.
        //Please note, that you need to print the numbers till the 3rd digit after the dot including trailing zeros.
        public static string SimpleDoubleSorting(string doubles)
        {
            var numbers = doubles.Split(' ').Select(d => Math.Round(double.Parse(d),3)).ToList();
            numbers.Sort();
            var newLine = string.Empty;
            int numDigitsAfterPoint = 3;
            newLine = numbers.Aggregate(newLine, (current, numSort) => current + (numSort.ToString("0." + new string('0', numDigitsAfterPoint)) + " "));
            return newLine.Substring(0,newLine.Length-1);
        }
    }
}
