using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;
using StackInheritanceLibrary;



namespace Linlin_Han_Lab04_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackInheritance();
            // create data to store in List
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;

            stack.Push(num1);
            stack.Push(num2);
            stack.Push(num3);

            Console.WriteLine("Get the stack using Push() method----");
            stack.Display();
            Console.WriteLine();

            Console.WriteLine("Get the first item of stack using Peek() method---");
            Console.WriteLine("The first item is " + stack.Peek());
            Console.WriteLine();

            Console.WriteLine("After using the Pop() method----");
            stack.Pop();
            stack.Display();
        }
    }
}
