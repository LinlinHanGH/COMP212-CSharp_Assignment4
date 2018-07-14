using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace Linlin_Han_Lab04_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();// create List container

            // create data to store in List
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;

            list.InsertAtFront(num1);
            list.InsertAtFront(num2);
            list.InsertAtFront(num3);

            list.Display();

            Console.WriteLine("Search( ) method: search for 1");
            list.Search(num1);
            Console.WriteLine("Search( ): search for 4");
            list.Search(4);
            Console.WriteLine();

            Console.WriteLine("Count( ) method");
            Console.WriteLine("The number of list items is " + list.Count());
            Console.WriteLine();

            Console.WriteLine("Sum() method");
            Console.WriteLine("The sum of list items is " + list.Sum());

        }
    }
}
