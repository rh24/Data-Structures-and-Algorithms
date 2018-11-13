using System;
using System.Collections.Generic;
using System.Text;

public class Hashtable
{
    // Use private set to grow size of Hashtable
    public int Buckets { get; set; } = 1024;
    public int PrimeMultiplier { get; set; } = 599;
    public LinkedListNode[] HT { get; set; } = new LinkedListNode[Buckets];

    // Default constructor
    public Hashtable()
    {
    }

    // Add
    public bool Add(string key, object value)
    {
        int asciiVal = 0;

        for (int i = 0; i < key.Length; i++)
        {
            asciiVal += Encoding.ASCII.GetBytes(key[i]);
        }

        HT[(asciiVal * PrimeMultiplier) % Buckets] = value;
    }
}
