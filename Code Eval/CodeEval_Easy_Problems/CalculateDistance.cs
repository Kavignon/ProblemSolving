using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    //You have coordinates of 2 points and need to find the distance between them.
    public static class CalculateDistance
    {
        public static int ComputeDistance(string somePoint)
        {
            var points = somePoint.Replace("(", "").Replace(")", "").Split(new [] { ',', ' ' },
                                 StringSplitOptions.RemoveEmptyEntries);

            var xSection = (Math.Pow(int.Parse(points[2]) - int.Parse(points[0]), 2));
            var ySection = (Math.Pow(int.Parse(points[3]) - int.Parse(points[1]), 2));
            return (int)Math.Floor(Math.Sqrt(Math.Abs(xSection) + Math.Abs(ySection)));
        }
    }
}
