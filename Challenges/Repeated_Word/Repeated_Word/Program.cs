using Hashtables;
using System;

namespace Repeated_Word
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string RepeatedWord(string longWord)
        {
            Hashtable ht = new Hashtable();
            string temp = "";
            string letters = "abcdefghijklmnopqrstuvwrxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < longWord.Length; i++)
            {
                if (letters.Contains(longWord[i])) String.Concat(temp, longWord[i]);
                else if (ht.Find(temp) == null)
                {
                    ht.Add(temp, 1);
                    temp = "";
                }
                else
                {
                    //ht.Add(temp, 2);
                    return temp;
                }
            }

            // Just in case there's no punctuation at the end of the string, and we still need to check for/add the last word of longWord in hashtable:
            if (ht.Find(temp) != null) return temp;
            else return null;

        }
    }
}
