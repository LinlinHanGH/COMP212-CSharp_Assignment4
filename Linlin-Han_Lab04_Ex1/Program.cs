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
            double[] numbers = { 1, 2, 3 };



            for (int i = 0; i < numbers.Length; i++)
            {
                list.InsertAtFront(numbers[i]);
            }

            list.Display();

            Console.WriteLine("Search( ) method: search for 1");
            list.Search(numbers[0]);
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
