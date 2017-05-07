using System;
using System.Linq;

namespace CodeEval_Easy_Problems
{
    public static class KnightMoves
    {
        public static string DeterminePossibleKnightPositions(string currentPosition)
        {
            var possiblePosition = new[]{
                (char)Convert.ToUInt16(currentPosition[0] +2) + ((char)Convert.ToUInt16(currentPosition[1] +1)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] +2) + ((char)Convert.ToUInt16(currentPosition[1] -1)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] +1) + ((char)Convert.ToUInt16(currentPosition[1] +2)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] +1) + ((char)Convert.ToUInt16(currentPosition[1] -2)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] -1) + ((char)Convert.ToUInt16(currentPosition[1] +2)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] -1) + ((char)Convert.ToUInt16(currentPosition[1] -2)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] -2) + ((char)Convert.ToUInt16(currentPosition[1] +1)).ToString(),
                (char)Convert.ToUInt16(currentPosition[0] -2) + ((char)Convert.ToUInt16(currentPosition[1] -1)).ToString(),
            }.ToList();

            possiblePosition.Sort();

            var knightPositions = possiblePosition
                .Where(pp => pp[0] >= 'a' && pp[0] <= 'h' && pp[1] <= '8' && pp[1] >= '1')
                .Aggregate(string.Empty, (current, pp) => current + (pp + " "));

            return knightPositions.Substring(0,knightPositions.Length-1);
        }
    }
}