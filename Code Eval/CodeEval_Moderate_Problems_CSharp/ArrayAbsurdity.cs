using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Moderate_Problems_CSharp
{
    public static class ArrayAbsurdity
    {
        public static string FindAbsurdNumberInArray(string line)
        {
            var splittedLine = line.Split(';');
            var number = int.Parse(splittedLine[0]);
            var arrayWithAbsurdity = new int[number];
            var numbers = splittedLine[1].Split(',');
            for(var i=0;i< number; i++)
            {
                int value;
                bool result = int.TryParse(numbers[i], out value);
                if (result)
                    arrayWithAbsurdity[i] = value;
            }
            Array.Sort(arrayWithAbsurdity);
            var duplicate = -1;

            for (int i = 0; i < arrayWithAbsurdity.Length; i++)
            {
                for (int j = i + 1; j < arrayWithAbsurdity.Length; j++)
                {
                    if (arrayWithAbsurdity[i] == arrayWithAbsurdity[j]) duplicate = arrayWithAbsurdity[i];
                }
            }

            return duplicate.ToString();
        }

    

    }
}
