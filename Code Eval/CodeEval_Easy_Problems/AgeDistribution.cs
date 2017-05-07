using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CHALLENGE DESCRIPTION:

You're responsible for providing a demographic report for your local school district based on age. To do this, you're going determine which 'category' each person fits into based on their age.
The person's age will determine which category they should be in:
https://www.codeeval.com/open_challenges/152/
*/
namespace CodeEval_Easy_Problems
{
    public static class AgeDistribution
    {
        public static Dictionary<string, List<int>> CategoryDistribution = new Dictionary<string, List<int>>()
        {
            { "Still in Mama's arms", Enumerable.Range(0,3).ToList()},
            { "Preschool Maniac", Enumerable.Range(3,2).ToList()},
            { "Elementary school", Enumerable.Range(5,7).ToList()},
            { "Middle school", Enumerable.Range(12,3).ToList()},
            { "High school", Enumerable.Range(15,4).ToList()},
            { "College", Enumerable.Range(19,4).ToList()},
            { "Working for the man", Enumerable.Range(23,43).ToList()},
            { "The Golden Years", Enumerable.Range(66,45).ToList()}
        };

        public static string DetermineAgeCategory(string personAge)
        {
            var parsedAge = int.Parse(personAge);
            var category = (from kvp in CategoryDistribution
                where kvp.Value.Contains(parsedAge)
                select kvp.Key).FirstOrDefault();
            return category;
        }

    }
}
