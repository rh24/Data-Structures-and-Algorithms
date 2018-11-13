using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine($"ht Buckets: {ht.HT.Length}");
            Console.WriteLine(ht.Add("wen", "turtle"));
        }
    }
}
