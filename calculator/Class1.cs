using System;
using System.Collections.Generic;

namespace Calculator
{
    public static class Calculator
    {
        private static Dictionary<string,decimal> values = new Dictionary<string,decimal>();
        /// <summary>
        /// pass the math problem to evaluate
        /// it can include
        /// +-*/^ () symbols
        /// sin(,cos(,tan(,sin-1(,cos-1(,tan-1(,abs,ln(,log10( functions
        /// </summary>
        /// <param name="eq"></param>
        /// <returns></returns>
        public static decimal Eval(string eq)
        {
            smartmodifier sm=new smartmodifier();
            operation op = new operation(eq, sm,values);
            return op.calc();
        }
    }
}
