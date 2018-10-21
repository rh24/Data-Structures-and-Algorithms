using System;
using LinkList.Classes;

namespace LLReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ReverseLLInPlace(LList ll)
        {
            Node a;
            Node b;
            Node c;

            ll.Current = ll.Head;

            while (ll.Current.Next.Next != null)
            {
                a = ll.Current;
                b = a.Next;
                c = b.Next;

                a = c;
                a.Next = b;
                b.Next = ll.Current;
                ll.Current = c;
            }

            ll.Head = ll.Current;

            return ll;
        }
    }
}
