using System;
using LinkList.Classes;

namespace LLMergeTwo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static LList MergeTwoLL(LList l1, LList l2)
        {
            Node pointer1 = l1.Current.Next;
            Node pointer2 = l2.Current.Next;

            l1.Current = l1.Head;
            l2.Current = l2.Head;

            while (l1.Current.Next != null || l2.Current.Next != null)
            {
                l1.Current.Next = l2.Current;
                l2.Current.Next = pointer1;
                l2.Current = pointer2;
                l1.Current = pointer1;

                pointer2 = l2.Current.Next;
                pointer1 = l1.Current.Next;
            }

            return l1;
        }

    }
}
