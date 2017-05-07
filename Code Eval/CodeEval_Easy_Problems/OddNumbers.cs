using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy_Problems
{
    //Instead of printing, I'll let the odd numbers inside the IEnumerable class implementation
    //Will be easier to test with unit test such as list[1] == 3
    public static class OddNumbers
    {
        //Print the odd numbers from 1 to 99, one number per line.
        public static List<int> ComputeOddNumberList()
        {
            return Enumerable.Range(0, 100).Where(i => i%2 != 0).ToList();
        }
    }
}
