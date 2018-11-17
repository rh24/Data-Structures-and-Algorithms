using System;
using System.Collections;
using System.Text;

namespace MostCommonWord_EC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string MostCommonWord(string book)
        {
            Hashtable ht = new Hashtable();
            StringBuilder temp = new StringBuilder();
            string letters = "abcdefghijklmnopqrstuvwyz";
            string mostCommon = "";
            int tempMax = 1;

            for (int i = 0; i < book.Length; i++)
            {
                if (letters.Contains(book[i])) temp.Append(book[i]);
                else
                {
                    if (mostCommon == "") mostCommon = temp.ToString();
                    if (!ht.ContainsKey(temp)) ht.Add(temp.ToString(), 1);
                    else
                    {
                        ht[key: temp.ToString()] = (int)ht[key: temp.ToString()] + 1;
                        if ((int)ht[key: temp.ToString()] > tempMax) mostCommon = temp.ToString();
                    }
                }

            }

            return mostCommon;
        }
    }
}
