using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PolishCalc
{
    /// <summary> Polish notation calc</summary>
    public static class Calculator
    {
        /// <summary> Regex for only numbers, '+', '-', '/', '*', ',' </summary>
        readonly static Regex validPattern = new Regex(@"^[0-9 ,+-\/\*\(\)]*$");
        
        /// <summary>Math functions</summary>
        private static readonly Dictionary<string, Func<double, double, double>> _functions = new Dictionary<string, Func<double, double, double>>()
        {
            {"+", new Func<double, double, double>( (double num1, double num2) => { return num1 + num2; } )},
            {"-", new Func<double, double, double>( (double num1, double num2) => { return num1 - num2; } )},
            {"/", new Func<double, double, double>( (double num1, double num2) => { return num1 / num2; } )},
            {"*", new Func<double, double, double>( (double num1, double num2) => { return num1 * num2; } )},
        };

        /// <summary> Calc math expression in polish notation </summary>
        /// <param name="expr">Math expression in polish notation </param>
        /// <returns>Result of math expression </returns>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="InvalidOperationException"/>
        public static double Calc(string expr)
        {
            if (string.IsNullOrEmpty(expr)) { throw new ArgumentException("Expression can't be null or empty"); }
            if (!validPattern.IsMatch(expr)) { throw new ArgumentException("Expression must contains only numbers, operators '+','-','/','*', ',','(',')' "); }            


            foreach (var oper in _functions.Keys)
            {
                //in case of someone forgot to separate operators with space symbol
                expr = expr.Replace(oper, " " + oper + " ");
            }

            expr = expr.Replace(')', ' ').Replace('(', ' '); //in polish notation brackets are not important

            var stack = new Stack<double>();

            foreach (var item in expr.Split(' ').Reverse<string>())
            {
                if(string.IsNullOrEmpty(item))
                {
                    continue;
                }

                double tmp = double.NaN;
                if (double.TryParse(item, out tmp))
                {
                    stack.Push(tmp);
                    continue;
                }

                if (_functions.ContainsKey(item))
                {
                    stack.Push(_functions[item](stack.Pop(), stack.Pop()));
                    continue;
                }

            }

            return stack.Pop();
        }


    }
}
