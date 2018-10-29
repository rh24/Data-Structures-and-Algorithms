using System;
using StackAndQueue.Classes;

namespace EenieMeenie
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "wen", "rebecca", "cat", "turtle", "jimmy", "jeff", "kimchi", "pepper" };
            Console.WriteLine(EeneyMeeneyMineyMoe(people, 4));
        }

        public static string EeneyMeeneyMineyMoe(string[] people, int n)
        {
            Queue queue = new Queue(new Node(people[0]));

            for (int i = 1; i < people.Length; i++)
            {
                queue.Enqueue(new Node(people[i]));
            }

            while (queue.Front != queue.Rear)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                queue.Dequeue();
            }

            return (string)queue.Front.Value;
        }
    }
}
