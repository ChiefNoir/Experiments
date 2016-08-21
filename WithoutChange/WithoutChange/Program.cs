using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuxoftWithoutChange.Utils;
using System.IO;
using System.Diagnostics;

namespace LuxoftWithoutChange
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[]
            {
                @"D:\1.txt",
                @"D:\2.txt",
            };


            if (!args.Any() || args.Length != 2 || !File.Exists(args[0]))
                return;

            var text = File.ReadAllLines(args[0]);

            var result = new StringBuilder();

            
            int i = 1;
            foreach (var item in text)
            {
                Stopwatch st = new Stopwatch();
                st.Start();

                var ints = Converters.ToIntList(item.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                var sums = SumFinder.FindSumSequences(ints.First(), ints.Skip(1));

                result.AppendFormat("{0}\r\n{1}", string.Join(",",sums), sums.Any() ? "YES" : "NO");
                Console.WriteLine(string.Format("{0} -- {1}\r\n{2}\r\n\r\n", i++, st.Elapsed, item));
            }
            
            Console.ReadKey();
            File.WriteAllText(args[1], result.ToString());
        }
        
    }
}
