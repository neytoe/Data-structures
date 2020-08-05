using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week3Task
{
    //This Generic stack implements,
    //the basic behaviours of a stack using a list.
    //A stack uses FIFO (First in First Out)
    public class GenericQueue<T>
    {

        List<T> myQueue = new List<T>();

        //MaxCapacity was set to handle Queue overflow
        public int MaxCapacity = 100;


        #region IsEmpty Method
        //returns true if a Queue is empty
        public bool IsEmpty()
        {
            return myQueue.Count == 0;

        }
        #endregion



        #region Enqueue Method
        //inserts an item at the end of the Queue
        public void Enqueue(T value)
        {
            if (MaxCapacity > myQueue.Count)
            {
                myQueue.Add(value);
            }

            else
            {
                Console.WriteLine("Stack is full");
            }

        }
        #endregion



        #region Peek Method

        //this returns the oldest item in the queue
        public T Peek()
        {   
            if (myQueue.Count >= 1) return myQueue[0];
            throw new Exception("Queue is currently empty");

        }
        #endregion




        #region Size Method
        //this return the count of the stack
        public int Size()
        {
            return myQueue.Count;
        }
        #endregion



        #region Print Method

        //this shows all items in the stack
        public void Print()
        {
            
            
            if (myQueue.Count == 0)
            {
                Console.WriteLine("There is Currently no item in the Queue");
            }
            else
            {
                Console.WriteLine("These are the items in the Queue");
                int number = 0;
                foreach (var item in myQueue)
            {
                number++;
                Console.WriteLine($"{number}:    {item}");
            }
            }
        }
        #endregion



        #region Dequeue Method

        public void Dequeue()
        {
            myQueue.RemoveAt(0);
        }
        #endregion


    }
}
