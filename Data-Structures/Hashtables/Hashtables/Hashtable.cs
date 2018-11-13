using System;
using System.Collections.Generic;
using System.Text;

public class Hashtable
{
    // Properties
    public int Buckets { get; set; }
    public int PrimeMultiplier { get; set; } = 599;
    public LinkedList<object>[] HT { get; set; } = new LinkedList<object>[1024];

    // Default constructor
    public Hashtable()
    {
    }

    /// <summary>
    /// Add key value pair to Hashtable object. First generate the bytes from a given string. Then, sum the ASCII values of each char in the string. Multiply it by the Hashtable object's prime number property, then use modulus to determine the index of the bucket the new key-value pair will be stored.
    /// </summary>
    /// <param name="key">String to look up in hashtable</param>
    /// <param name="value">Value to be stored in hashtable</param>
    /// <returns>true if try code block is successfully executed</returns>
    public bool Add(string key, object value)
    {
        try
        {
            byte[] bytes = Encoding.ASCII.GetBytes(key);
            int asciiVal = 0;

            for (int i = 0; i < bytes.Length; i++)
            {
                asciiVal += bytes[i];
            }

            int bucket = (asciiVal * PrimeMultiplier) % HT.Length;

            if (HT[bucket] == null)
            {
                HT[bucket] = new LinkedList<object>();
                HT[bucket].AddFirst(new LinkedListNode<object>(value));
            }
            else
            {
                HT[bucket].AddLast(new LinkedListNode<object>(value));
            }

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
