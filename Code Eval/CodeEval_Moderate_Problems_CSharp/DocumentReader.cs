using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Moderate_Problems_CSharp
{
    public static class DocumentReader
    {
        public static string DetermineLongestLinesInFile(string file)
        {
            var lines = file.Split(',').ToList();
            int numberOfPrintedLines = int.Parse(lines[0]);
             var content = lines.OrderByDescending(s => s.Length).ToList();
            var longestLines = content.Take(numberOfPrintedLines);
            var longestLine = longestLines.Aggregate(string.Empty, (current, s) => current + s + "\n");
            return longestLine;
        }

        public static void CodeEval_LongestLine_Method(string[] args)
        {
            var lines = File.ReadAllLines(args[0]);
            int numberOfPrintedLines;
            if (!int.TryParse(lines[0], out numberOfPrintedLines)) return;
            var content = lines.OrderByDescending(s => s.Length).ToList();
            var longestLines = content.Take(numberOfPrintedLines);
            var longestLine = longestLines.Aggregate(string.Empty, (current, s) => current + s + "\n");
            Console.WriteLine(longestLine);
        }
    }
}
