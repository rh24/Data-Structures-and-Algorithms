using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine($"ht Buckets: {ht.HT.Length}");
            Console.WriteLine("Adding key: 'wen', value: 'turtle'");
            Console.WriteLine(ht.Add("wen", "turtle"));
            Console.WriteLine("Find value of 'wen' by looking up key in hashtable:");
            Console.WriteLine(ht.Find("wen"));
        }
    }
}
