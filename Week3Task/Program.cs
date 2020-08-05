using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Week3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-------------------------STACK------------------");
            Console.WriteLine("------------------------------------------------------");
            // This shows the functinality of the stack
            var stack = new GenericStack<string>();
            Console.WriteLine($"is the stack empty? {stack.IsEmpty()}");
            stack.Push("yadi");

            Console.WriteLine($"is the stack empty? {stack.IsEmpty()}");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("jide");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("yadi");
            stack.Push("yadi");
            Console.WriteLine($"The current count of the stack is {stack.Size()}");

            Console.WriteLine($"The top of the stack contains {stack.Peek()}");
            stack.Print();
            Console.WriteLine("remove the last item added");
            stack.Pop();
            Console.WriteLine($"The current count of the stack is {stack.Size()}");
            stack.Print();
            Console.WriteLine($"The top of the stack contains {stack.Peek()}");

            Console.WriteLine("***********************************");
            Console.WriteLine("");

            Console.WriteLine("***********************************");


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-------------------------QUEUE------------------------");
            Console.WriteLine("------------------------------------------------------");

            //This shows the functionality of a queue;
            var Queue = new GenericQueue<string>();
            Console.WriteLine($"is the Queue empty? {Queue.IsEmpty()}");
            Queue.Enqueue("neto");
            Queue.Enqueue("yadi");
            Queue.Enqueue("jide");
            Console.WriteLine($"is the Queue empty? {Queue.IsEmpty()}");
            Console.WriteLine($"The current count of the stack is {Queue.Size()}");

            Console.WriteLine($"The oldest element of the Queue is {Queue.Peek()}");
            Queue.Print();
            Console.WriteLine("removing the last item added");
            Queue.Dequeue();
            Console.WriteLine("Current state of the queue:");
            Queue.Print();
            Console.WriteLine($"The oldest element of the Queue is {Queue.Peek()}");


            /*
            ********LINKED LIST***********
            */
            //This shows the functionality of the linked list


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-------------------------LINKED LIST------------------");
            Console.WriteLine("------------------------------------------------------");
            var node = new GenericLinkedList<string>();

            Console.WriteLine("is node empty?");
            Thread.Sleep(1000);

            Console.WriteLine(node.IsEmpty());
            Thread.Sleep(1000);
            Console.WriteLine("adding items");
            node.Add("neto");
            node.Add("love");
            node.Add("netoo");
            node.Add("Its True Love!!");

            Console.WriteLine($"this is the current node size: {node.Size()}");

            node.Insert("love garden", 3);
            Console.WriteLine("***");
            Console.WriteLine(node.Index("fatima"));
            Console.WriteLine("*****");
            var current = node.head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.WriteLine(node.IsEmpty());

            Console.WriteLine(node.Size());
            Console.WriteLine(node.IsEmpty());
            node.Remove("netoo");


            Console.WriteLine("How many items are in the list?");
            Thread.Sleep(1000);
            Console.WriteLine(node.Size());



        }
    }
}
