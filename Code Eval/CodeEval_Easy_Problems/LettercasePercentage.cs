using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    public static class LettercasePercentage
    {
        public static string ComputeLettercaseRatio(string input)
        {
            var ratio = 0.0;
            foreach (var c in input)
            {
                if (char.IsLower(c))
                    ratio++;
            }
            ratio = (ratio/input.Length) * 100.00;
            return "lowercase: " + ratio.ToString("0." + new string('0', 2)) + " uppercase: "+ (100 -ratio).ToString("0." + new string('0', 2));
        }

        static void CodeEval_LettercaseRatio(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    var ratio = 0.0;
                    foreach (var c in line)
                    {
                        if (char.IsLower(c))
                            ratio++;
                    }
                    ratio = (ratio / line.Length) * 100.00;
                    Console.WriteLine("lowercase: " + ratio.ToString("0." + new string('0', 2)) + " uppercase: " + (100 - ratio).ToString("0." + new string('0', 2)));

                }
        }
    }
}
