using System;
using System.Collections;

namespace SequentialCollections
{
    internal class Program
    {
        static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                Console.WriteLine("From Queue: {0}", queue.Dequeue());
            }

            Stack stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                Console.WriteLine("From Stack: {0}", stack.Pop());
            }
        }
    }
}