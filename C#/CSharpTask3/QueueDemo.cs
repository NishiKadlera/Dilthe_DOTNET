using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class QueueDemo
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();//creatig an instance

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Enqueue("Five");

            Console.WriteLine("QUEUE\n*****************************");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Top element in the Queue before Dequeue:{0}", queue.Peek());
            Console.WriteLine("whether Six is present:{0}", queue.Contains("Six"));

            queue.Dequeue();
            Console.WriteLine("Queue after Dqueue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Top element in the Queue after Dequeue:{0}",queue.Peek());
            Console.WriteLine("whether Two is present:{0}", queue.Contains("Two"));
        }
        
    }
}
