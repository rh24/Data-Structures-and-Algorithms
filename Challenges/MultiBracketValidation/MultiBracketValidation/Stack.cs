using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation
{
    public class Stack
    {
        public static int count = 0;
        public static object Top { get; set; }
        public static int Size { get; set; } = count;

        public Stack(object value)
        {
            Top = value;
            count++;
        }
    }
}
