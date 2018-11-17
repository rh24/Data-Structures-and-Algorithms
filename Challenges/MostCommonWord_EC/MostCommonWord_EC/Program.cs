using System;
using System.Collections;
using System.Text;

namespace MostCommonWord_EC
{
    public class Program
    {
        static void Main(string[] args)
        {
            string book = "CATS CATS CATS CATS CATS, and they are all fat.";
            Console.WriteLine(MostCommonWord(book));
        }

        public static string MostCommonWord(string book)
        {
            Hashtable ht = new Hashtable();
            StringBuilder temp = new StringBuilder();
            string letters = "abcdefghijklmnopqrstuvwyz";
            string mostCommon = null;
            int tempMax = 1;

            for (int i = 0; i < book.Length; i++)
            {
                if (mostCommon == null) mostCommon = temp.ToString();
                if (letters.Contains(Char.ToLower(book[i]))) temp.Append(book[i]);
                else
                {
                    if (!ht.Contains(temp.ToString())) ht.Add(temp.ToString(), 1);
                    else
                    {
                        ht[key: temp.ToString()] = (int)ht[key: temp.ToString()] + 1;
                        if ((int)ht[key: temp.ToString()] > tempMax) mostCommon = temp.ToString();
                    }

                    temp.Clear();
                }

            }

            return mostCommon;
        }
    }
}
