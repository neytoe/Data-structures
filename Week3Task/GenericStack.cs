using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    //This Generic stack implements,
    //the basic behaviours of a stack using a list.
    //A stack uses LIFO (Last in First Out)
  public class GenericStack<T>
    {
        List<T> myList = new List<T>();



        //MaxCapacity was created to handle stack overflow
        public int MaxCapacity = 100;



        #region IsEmpty Method
        //returns true if a stack is empty
        public bool IsEmpty()
        {
            return myList.Count == 0;                
                
        }
        #endregion



        #region Push Method
        //inserts an item at the top of the stack
        public void Push (T value)
        {
            if( MaxCapacity > myList.Count)
            {
                myList.Add(value);
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }
        #endregion


        #region Peek Method
        //this returns the top item in the stack
        public T Peek()
        {
            return myList[myList.Count - 1];
        }
        #endregion


        #region Size Method
        //this return the count of the stack
        public int Size()
        {
            return myList.Count;
        }
        #endregion



        #region Print Method
        //this shows all items in the stack
        public void Print()
        {
            int number = 0;
            Console.WriteLine("These are the items in the stack");
            foreach (var item in myList)
            {
                number++;
                Console.WriteLine($"{number}:    {item}");
            }
        }
        #endregion


        #region Pop Method
        //Removes item at the top of the stack
        public void Pop ()
        {
            myList.RemoveAt(myList.Count - 1);
        }
        #endregion
    }
}
