using Plazius.Common;
using System.Collections.Generic;
using System.Linq;

namespace Plazius.Utils
{
    public static class AdopterHelpers
    {
        public static IEnumerable<Route> Sort(IEnumerable<Route> rotes)
        {
            var result = new List<Route> { rotes.First() };

            var starts = rotes.Skip(1).ToDictionary(x => x.Start);
            var ends = rotes.Skip(1).ToDictionary(x => x.End);

            while (starts.Any() && ends.Any())
            {
                var first = result.First();
                if (ends.ContainsKey(first.Start))
                {
                    var e = ends[first.Start];
                    result.Insert(0, e);

                    ends.Remove(e.End);
                    starts.Remove(e.Start);
                }

                var last = result.Last();
                if (starts.ContainsKey(last.End))
                {
                    var e = starts[last.End];
                    result.Add(e);

                    ends.Remove(e.End);
                    starts.Remove(e.Start);
                }
            }

            
            return result;
        }
    }
}
