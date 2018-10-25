using System;
using StackAndQueue.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input1 = "[](){}";
            string input2 = "][)";
            string input3 = "ae[o]{|}";

            Stack holdingStack = new Stack(null);

            // A Stack instantiated with null should have a Size property of 0.
            //Console.WriteLine($"{holdingStack.Size}");

            Console.WriteLine("[](){}: " + MultibracketValidation(input1));
            Console.WriteLine("][): " + MultibracketValidation(input2));
            Console.WriteLine("ae[o]{|}: " + MultibracketValidation(input3));

        }

        public static bool MultibracketValidation(string input)
        {
            Stack holdingStack = new Stack(null);

            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();

                if (character == "{" || character == "[" || character == "(")
                {
                    holdingStack.Push(new Node(input[i]));
                }
                else
                {
                    string ch = input[i].ToString();

                    switch (ch)
                    {
                        case "}":
                            if (holdingStack.Size == 0) return false;
                            return holdingStack.Pop().Value.ToString() == "{";
                        case "]":
                            if (holdingStack.Size == 0) return false;
                            return holdingStack.Pop().Value.ToString() == "[";
                        case ")":
                            if (holdingStack.Size == 0) return false;
                            return holdingStack.Pop().Value.ToString() == "(";
                        default:
                            continue;
                    }
                }
            }

            return true;
        }
    }
}
