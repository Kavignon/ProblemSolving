using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    public static class SwapCase
    {
        public static string ChangeLetterCase(string str)
        {
            var resultString = string.Empty;
            foreach (var c in str)
            {
                if (char.IsUpper(c))
                    resultString += char.ToLower(c);
                else
                {
                    resultString += char.ToUpper(c);
                }
            }
            return resultString;
        }

        public static string SwapElementIndex(string input)
        {
            var splitInput = input.Split(':');
            var values = splitInput[0].Split(' ').ToArray();
            var indexes = splitInput[1].Split(',');
            foreach (var i in indexes)
            {
                var swaps = i.Substring(1).Split('-').Select(int.Parse).ToList();
                var tmp = values[swaps[1]];
                values[swaps[1]] = values[swaps[0]];
                values[swaps[0]] = tmp;
            }
            var afterSwap = values.Aggregate(string.Empty, (current, i) => current + (i + " "));
            return afterSwap.Substring(0, afterSwap.Length - 2);
        }

        static void CodeEval_SwapElement_Index(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    var splitInput = line.Split(':');
                    var values = splitInput[0].Split(' ').ToArray();
                    var indexes = splitInput[1].Split(',');
                    foreach (var i in indexes)
                    {
                        var swaps = i.Substring(1).Split('-').Select(int.Parse).ToList();
                        var tmp = values[swaps[1]];
                        values[swaps[1]] = values[swaps[0]];
                        values[swaps[0]] = tmp;
                    }
                    var afterSwap = values.Aggregate(string.Empty, (current, i) => current + (i + " "));
                    Console.WriteLine(afterSwap.Substring(0, afterSwap.Length - 2));
                }
        }
    }
}
