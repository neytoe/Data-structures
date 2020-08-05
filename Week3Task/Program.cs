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
            //This shows the functinality of the stack
            //var stack = new GenericStack<string>();
            //Console.WriteLine($"is the stack empty? {stack.IsEmpty()}");
            //stack.Push("yadi");

            //Console.WriteLine($"is the stack empty? {stack.IsEmpty()}");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("jide");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //stack.Push("yadi");
            //Console.WriteLine($"The current size of the stack is {stack.Size()}");

            //Console.WriteLine($"The top of the stack contains {stack.Peek()}");
            //stack.Print();
            //Console.WriteLine("remove the last item added");
            //stack.Pop();
            //Console.WriteLine($"The current size of the stack is {stack.Size()}");
            //stack.Print();
            //Console.WriteLine($"The top of the stack contains {stack.Peek()}");

            //Console.WriteLine("***********************************");
            //Console.WriteLine("");

            //Console.WriteLine("***********************************");

            ////This shows the functionality of a queue;
            //var Queue = new GenericQueue<string>();
            //Console.WriteLine($"is the Queue empty? {Queue.IsEmpty()}");
            //Queue.Enqueue("neto");
            //Queue.Enqueue("yadi");
            //Queue.Enqueue("jide");
            //Console.WriteLine($"is the Queue empty? {Queue.IsEmpty()}");
            //Console.WriteLine($"The current size of the stack is {Queue.Size()}");

            //Console.WriteLine($"The oldest element of the Queue is {Queue.Peek()}");
            //Queue.Print();
            //Console.WriteLine("removing the last item added");
            //Queue.Dequeue();
            //Console.WriteLine("Current state of the queue:");
            //Queue.Print();
            //Console.WriteLine($"The oldest element of the Queue is {Queue.Peek()}");


            //This shows the functionality of the linked list
             
            var node = new GenericLinkedList<string>();

            Console.WriteLine("is node empty?");
            Thread.Sleep(1000);

            Console.WriteLine(node.IsEmpty());
            node.Add("neto");
            node.Add("love");
            node.Add("fatima");
            Console.WriteLine(node.Count());
            Console.WriteLine(node.Search("fatima"));
            Console.WriteLine(node.Search("jide"));

            //node.Add(10);
            //Console.WriteLine(node.Count());
            //Console.WriteLine(node.IsEmpty());
            //Console.WriteLine("IS 9 present ->" + node.Check(9));
            //node.Remove(9);
            //Console.WriteLine("IS 9 present ->" + node.Check(9));
            //Console.WriteLine(node.Count());
            //Console.WriteLine("IS 10 present ->" + node.Check(10));
            //node.Remove(10);
            //Console.WriteLine("IS 10 present ->" + node.Check(10));
            //Console.WriteLine(node.Count());
            //Console.WriteLine(node.IsEmpty());


            //Console.WriteLine("How many items are in the list?");
            //Thread.Sleep(1000);
            //Console.WriteLine(node.Count());



        }
    }
}
