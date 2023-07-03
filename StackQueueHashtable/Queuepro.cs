using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashtable
{
    internal class Queuepro
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            queue.Dequeue();

            Console.WriteLine($"first element in the list {queue.Peek()}");
            Console.WriteLine($"total elements in the queue {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
