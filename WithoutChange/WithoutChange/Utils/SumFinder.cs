using System;
using System.Collections.Generic;
using System.Linq;

namespace LuxoftWithoutChange.Utils
{
    public static class SumFinder
    {
        /// <summary>Find sequences in <c>elements</c> which sum is equals to the <c>goal</c></summary>
        /// <param name="goal">Sum goal</param>
        /// <param name="elements">Element for seek</param>
        /// <returns>Sequences in <c>elements</c> which sum is equals to the <c>goal</c></returns>
        public static List<int> FindSumSequences(int goal, IEnumerable<int> elements)
        {
            if (elements == null) throw new ArgumentNullException("elements can't be null");
            if (!elements.Any()) return new List<int>();

            var result = RecursiveSeek(goal, 0, new List<int>(), new List<int>(elements), 0);

            if (result.Any())
                return result.First();
            return new List<int>();
        }

        private static List<List<int>> RecursiveSeek(int goal, int currentSum, List<int> included, List<int> notIncluded, int startIndex)
        {
            List<List<int>> results = new List<List<int>>();
            
            for (int i = startIndex; i < notIncluded.Count; i++)
            {
                //Well, I'm not that fascinated to optimise NP-hard problem in weekends 
                //sometimes it'll work too long, sometimes it'll crash
                //Oh, well
                if (results.Count > 0) return results;

                var nextValue = notIncluded[i];
                if (currentSum + nextValue == goal)
                {
                    var newResult = new List<int>(included);
                    newResult.Add(nextValue);
                    results.Add(newResult);
                    continue;
                }

                if (currentSum + nextValue < goal)
                {
                    var nextIncluded = new List<int>(included);
                    nextIncluded.Add(nextValue);
                    var nextNotIncluded = new List<int>(notIncluded);
                    nextNotIncluded.Remove(nextValue);

                    results.AddRange
                        (
                            RecursiveSeek(goal, currentSum + nextValue, nextIncluded, nextNotIncluded, startIndex++)
                        );

                    continue;
                }
            }

            return results;
        }
    }
}
