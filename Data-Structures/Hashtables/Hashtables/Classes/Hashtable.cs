using System;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        // Properties
        public int Buckets { get; set; }
        public int PrimeMultiplier { get; set; } = 599;
        public LinkedList[] HT { get; set; } = new LinkedList[1024];

        // Default constructor
        public Hashtable()
        {
        }

        /// <summary>
        /// Add key value pair to Hashtable object. First generate the bytes from a given string. Then, sum the ASCII values of each char in the string. Multiply it by the Hashtable object's prime number property, then use modulus to determine the index of the bucket the new key-value pair will be stored. Update an existing node's value with the new passed in value if the same key already exists in the hashtable.
        /// </summary>
        /// <param name="key">String to look up in hashtable</param>
        /// <param name="value">Value to be stored in hashtable</param>
        /// <returns>true if try code block is successfully executed</returns>
        public bool Add(string key, object value)
        {
            try
            {
                int bucket = GetHash(key);
                Node nodeToAdd = new Node(value) { Key = key };

                if (HT[bucket] == null) HT[bucket] = new LinkedList(nodeToAdd);
                else if (Find(key) == null) HT[bucket].Add(nodeToAdd);
                else FindNode(key).Value = value;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Get the value of an item in the hashtable by looking up its key.
        /// </summary>
        /// <param name="key">String to look up in hashtable</param>
        /// <returns>Value of the key</returns>
        public object Find(string key)
        {
            int bucket = GetHash(key);

            if (HT[bucket] != null)
            {
                Node current = HT[bucket].Head;

                while (current != null)
                {
                    if ((string)current.Key == key) return current.Value;
                    current = current.Next;
                }
            }

            return null;
        }

        /// <summary>
        /// Find and return a node instead of a value. 
        /// </summary>
        /// <param name="key">String to look up in hashtable</param>
        /// <returns>Node found</returns>
        public Node FindNode(string key)
        {
            int bucket = GetHash(key);
            Node current = HT[bucket].Head;

            while (current != null)
            {
                if ((string)current.Key == key) return current;
                current = current.Next;
            }

            return null;
        }

        /// <summary>
        /// Helper method to calculate hash of the key
        /// </summary>
        /// <param name="key">Look up string</param>
        /// <returns>Bucket index</returns>
        public int GetHash(string key)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(key);
            int asciiVal = 0;

            for (int i = 0; i < bytes.Length; i++)
            {
                asciiVal += bytes[i];
            }

            int bucket = (asciiVal * PrimeMultiplier) % HT.Length;

            return bucket;
        }
    }

}
