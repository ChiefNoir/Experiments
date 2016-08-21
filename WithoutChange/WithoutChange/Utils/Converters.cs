using System;
using System.Collections.Generic;
using System.Linq;

namespace LuxoftWithoutChange.Utils
{
    public static class Converters
    {
        /// <summary>Converts string collection to int collection</summary>
        /// <param name="collection">String collection of ints</param>
        /// <returns>Ints collection</returns>
        public static IEnumerable<int> ToIntList(IEnumerable<string> collection)
        {
            if (collection == null) throw new ArgumentNullException("String collection is null");
            if (!collection.Any()) return new List<int>();

            var lst = new List<int>();

            foreach (var str in collection)
            {
                //is str is not int so let it Exception be thrown
                lst.Add(Convert.ToInt32(str)); 
            }
            
            return lst;
        }

    }
}
