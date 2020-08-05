using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    /*
     * 
     */
    public class GenericLinkedList<T>
    {
        public Node<T> head;//indicates the first node in the list 


        private int count;//Indicates how many items are in the list
       

        //Constructor for the class
        public GenericLinkedList()
        {
            this.head = null;
            this.count = 0;
        }


        #region IsEmpty Method
        //this indicates the empty public property
        public bool IsEmpty ()
        {
             return this.count == 0;
        }

        #endregion




        #region Size Method
        //this indicates the number of items in the list
        public int Size() 
        {
             return this.count; 
        }
        #endregion


        #region Add Method
        /*This methods adds value into the list
         * 
         */
        public int Add(T value)
        {

            Node<T> newNode = new Node<T>(value, null);
            if (head == null)
            {
                head = newNode;
                this.count++;
                return this.count;
            }
            //create a new node called current and 
            //assign head to it
            Node<T> curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }

             
            curr.next = newNode;
          
            
            this.count++;
          
            return this.count;
        }
        #endregion



        #region Remove Method
        /*This method removes a value in the list
         */
        public void Remove(T value)
        {

            Node<T> current = head;

            Node<T> prev = null;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    if (prev == null) head = current.next;
                    else prev = current.next;
                    break;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            this.count--;
        }

        #endregion




        #region Check Method

        /* this checks if a value is present in the list
         * returns true if the value exist,
         * returns false if it doesn't.
         */
        public bool Check(T value)
        {

            Node<T> current = head;

            Node<T> prev = null;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                   
                    return true;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return false;
        }
        #endregion



        #region Search Method
        //This method searches for a value and returns the value
        //But returns the default value of the Type if the value is not found
        public T Search(T value)
        {

            Node<T> current = head;

            Node<T> prev = null;
            while (current != null)
            {
                if (current.data.Equals(value))
                {

                    return current.data;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return default(T);
        }

        #endregion



        #region Insert Method

        /*inserts an item at a specified index,
         * returns the value if successful,
         * and return the default values type
         */
        public T Insert(T value, int index)
        {

            Node<T> current = head;
            Node<T> newNode = new Node<T>(value, null);
            Node<T> prev = null;
            int counter = 0;
            while (current != null)
            {
                if (counter == index)
                {
                    this.count++;
                    newNode.next = current;
                    if (prev == null)
                    {
                        head = prev;
                    }
                    else prev.next = newNode;
                    return value;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
                counter++;
            }

            return default(T);
        }
        #endregion




        #region index Method
        /*
         * the index method returns the index of the value given
         */
        public int Index(T value)
        {

            Node<T> current = head;
            Node<T> newNode = new Node<T>(value, null);
            Node<T> prev = null;
            int counter = 0;
            while (current != null)
            {
                if (current.data.Equals(value))
                {

                    return counter;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
                counter++;
            }

            return -1;
        }
        #endregion
    }

}
      


