using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Moderate_Problems_CSharp
{
    public static class BinaryRepresentation
    {
        public static int NumberOfOnesInBinary(string binary)
        {
            return string.IsNullOrEmpty(binary) || !binary.Contains('1') ? 0 : binary.Count(v => v == '1');
        }
    }
}
