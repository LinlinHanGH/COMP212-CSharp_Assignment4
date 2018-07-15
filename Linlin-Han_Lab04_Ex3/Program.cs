using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;
using QueueInheritanceLibrary;

namespace Linlin_Han_Lab04_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueInheritance queue = new QueueInheritance();
            //create data to store in List
            string[] names = { "James", "Alice", "Bill" };

            for (int i = 0; i < names.Length; i++)
            {
                queue.Enqueue(names[i]);
            }

            Console.WriteLine("Get the stack using Enqueue() method----");
            queue.DisplayString();
            Console.WriteLine();

            Console.WriteLine("Remove from front using Dequeue() method----");
            queue.Dequeue();
            queue.DisplayString();
            Console.WriteLine();







        }
    }
}
