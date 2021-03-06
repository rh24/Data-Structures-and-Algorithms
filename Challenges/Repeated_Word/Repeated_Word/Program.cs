﻿using Hashtables;
using System;
using System.Text;

namespace Repeated_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Expected: null, won't print anything
            string test1 = "acatateanappleandbecameacatapple";
            // Expected: ""
            string test2 = ";;;;; ; ;; ;;;";
            // Expected: "a"
            string test3 = "a, cat, ate an apple and became a cat apple";
            // Expected: "turtles"
            string test4 = "turtles move slowly. they are turtles";
            // Expected: "an"
            string test5 = "an apple ate an apple and became an apple.";

            //Console.WriteLine(RepeatedWord(test1));
            Console.WriteLine(RepeatedWord(test2));
            //Console.WriteLine(RepeatedWord(test3));
            //Console.WriteLine(RepeatedWord(test4));
            //Console.WriteLine(RepeatedWord(test5));
        }

        /// <summary>
        /// Method that will take in a long string and return the first repeated word in the string.
        /// </summary>
        /// <param name="longWord">Lengthy string</param>
        /// <returns>First repeated word</returns>
        public static string RepeatedWord(string longWord)
        {
            Hashtable ht = new Hashtable();
            StringBuilder temp = new StringBuilder();
            string letters = "abcdefghijklmnopqrstuvwrxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < longWord.Length; i++)
            {
                if (letters.Contains(longWord[i])) temp.Append(longWord[i]);
                else if (ht.Find(temp.ToString()) == null && letters.Contains(longWord[i]) == true)
                {
                    ht.Add(temp.ToString(), 1);
                    temp.Clear();
                }
                else if (temp.ToString() != "") return temp.ToString();
                else return null;
            }

            // Just in case there's no punctuation at the end of the string, and we still need to check for/add the last word of longWord in hashtable:
            if (ht.Find(temp.ToString()) != null) return temp.ToString();
            else return null;
        }
    }
}
