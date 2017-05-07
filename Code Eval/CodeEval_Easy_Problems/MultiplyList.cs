using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    public static class MultiplyList
    {
        public static string Multiply_Elements_Within_List(string line)
        {
            var numbers = line.Split('|');
            var first = numbers[0].Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            var second = numbers[1].Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            var newNumbers = string.Empty;
            for (var i = 0; i < first.Length; i++)
            {
                newNumbers += int.Parse(first[i])*int.Parse(second[i]) + " ";
            }
            return newNumbers.Substring(0, newNumbers.Length-1);
        }
    }
}
