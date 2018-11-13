using System;

public class Hashtable
{
    // Use private set to grow size of Hashtable
    public int Buckets { get; private set; } = 1024;

    public Hashtable()
    {
    }
}
