using System;
using LinkList.Classes;

namespace LLMergeTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LList ll = new LList(node);
            ll.Add(node2);
            ll.Add(node4);

            LList ll2 = new LList(node1);
            ll2.Add(node3);

            Console.WriteLine("LL1: " + Environment.NewLine);
            ll.Print();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("LL2: " + Environment.NewLine);
            ll2.Print();

            Console.WriteLine("**********************  Merged LLs:  ***********************");
            MergeTwoLL(ll, ll2).Print();
        }

        public static LList MergeTwoLL(LList l1, LList l2)
        {
            Node pointer1 = l1.Current.Next;
            Node pointer2 = l2.Current.Next;

            l1.Current = l1.Head;
            l2.Current = l2.Head;

            while (pointer1 != null || pointer2 != null)
            {
                // These first two lines are necessary to not lose the rest of the longer list. These first two lines will never run if the Current.Next in either of the lists are null. That's why if conditionals are necessary at the end.
                l1.Current.Next = l2.Current;
                l2.Current.Next = pointer1;

                l1.Current = pointer1;
                l2.Current = pointer2;

                if (l1.Current != null) pointer1 = l1.Current.Next;
                if (l2.Current != null) pointer2 = l2.Current.Next;

            }

            if (pointer1 == null)
            {
                l1.Current.Next = l2.Current;
            }

            l1.Current = l1.Head;

            return l1;
        }

        public static Node FindLast(LList ll)
        {
            while (ll.Current.Next != null)
            {
                ll.Current = ll.Current.Next;
            }

            return ll.Current;
        }

        public static object FindKthFromLastWithWalkerRunner(int k, LList ll)
        {
            Node runner = ll.Current;
            Node walker = ll.Current;
            int counter = 0;

            while (counter < k)
            {
                runner = runner.Next;

                if (counter == k)
                {
                    while (runner.Next != null)
                    {
                        ll.Current = ll.Current.Next;
                        walker = ll.Current;
                    }
                }
            }

            return walker.Value;
        }
    }
}
