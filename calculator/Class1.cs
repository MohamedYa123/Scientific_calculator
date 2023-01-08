using System;
using System.Collections.Generic;

namespace Calculator
{
    public static class Calculator
    {
        static bool aboutcalled = false;
        public static string About()
        {
            aboutcalled = true;
            return "THIS CALCULATOR IS CREATED BY MOHAMED YASSER , JUPITERC TEAM" +
                "\r\nFOR CONTACT +201093272159" +
                "\r\n TO USE THE CALCULATOR CALL 'Calculator.Calculator.Eval(STRING);'";
        }
        static void setvariables()
        {
            if (values.Count == 0)
            {
                values.Add("π", (decimal)3.14159265359);
                values.Add("e", (decimal)2.71828182845);
                values.Add("X", 0);
                values.Add("Y", 0);
                values.Add("Z", 0);
            }
        }
        /// <summary>
        /// set value of any variable
        /// X,Y,Z
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void setvariable(string name, decimal value)
        {
            setvariables();
            values[name] = value;
        }
        private static Dictionary<string, decimal> values = new Dictionary<string, decimal>();
        /// <summary>
        /// pass the math problem to evaluate
        /// it can include
        /// +-*/^ () symbols
        /// sin(,cos(,tan(,sin-1(,cos-1(,tan-1(,abs,ln(,log10( functions
        /// !,ncr,npr
        /// variables X,Y,Z
        /// π,e
        /// </summary>
        /// <param name="eq"></param>
        /// <returns></returns>
        public static decimal Eval(string eq)
        {
            if (!aboutcalled)
            {
                throw new Exception("Kindly please call about function atleast one time (^_^)");
            }
            setvariables();
            smartmodifier sm = new smartmodifier();
            operation op = new operation(eq, sm, values);
            return op.calc();
        }

    }
}
