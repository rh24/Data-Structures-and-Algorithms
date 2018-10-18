using System;
using LinkList.Classes;

namespace LLMergeTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Node node0 = new Node("third");
            //Node node1 = new Node("world");
            //LList l1 = new LList(new Node("firstNode1"));
            //Node node2 = new Node("hello");
            //Node node3 = new Node("moon");

            //l1.Add(node0);
            //l1.Add(node2);
            //l1.Add(node3);

            //LList l2 = new LList(new Node("firstNode2"));
            //Node node4 = new Node("goodnight");
            //Node node5 = new Node("and stars");

            //l2.Add(node5);
            //l2.Add(node4);
            // Set up LL1
            LList l1 = new LList(new Node(1));

            // Set up LL2
            LList l2 = new LList(new Node(1));

            Node node0 = new Node(2);
            Node node1 = new Node(3);
            Node node2 = new Node(4);

            l1.Add(node0);
            l1.Add(node2);
            //l1.Add(node3);

            l2.Add(node1);
            //l2.Add(node4);

            MergeTwoLL(l1, l2).Print();
        }

        public static LList MergeTwoLL(LList l1, LList l2)
        {
            var pointer1 = l1.Current.Next;
            var pointer2 = l2.Current.Next;

            l1.Current = l1.Head;
            l2.Current = l2.Head;

            while (l2.Current.Next != null || l1.Current.Next != null)
            {
                // These first two lines are necessary to not lose the rest of the longer list. These first two lines will never run if the Current.Next in either of the lists are null. That's why if conditionals are necessary at the end.
                l1.Current.Next = l2.Current;
                l2.Current.Next = pointer1;

                l1.Current = pointer1;
                l2.Current = pointer2;
                pointer1 = l1.Current.Next;
                pointer2 = l2.Current.Next;

                if (pointer1 == null)
                {
                    l1.Current.Next = l2.Current;
                }
                if (pointer2 == null)
                {
                    l1.Current.Next = l2.Current;
                    l2.Current.Next = pointer1;
                }
            }



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

    }
}
