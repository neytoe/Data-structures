using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{

    public class GenericLinkedList<T>
    {
        public Node<T> head;//indicates the first node in the list 


        public int size;//Indicates how many items are in the list


        //Constructor for the class
        public GenericLinkedList()
        {
            this.head = null;
            this.size = 0;
        }



        /*
        *************************
        
        METHODS

        *************************
        */

        //this indicates the empty public property
        public bool IsEmpty ()
        {
             return this.size == 0;
        }


        //this indicates the number of items in the list
        public int Count() 
        {
             return this.size; 
        }

        public int Add(T value)
        {

            Node<T> newNode = new Node<T>(value, null);
            if (head == null)
            {
                head = newNode;
                this.size++;
                return this.size;
            }
            //create a new node called current and 
            //assign headNode to it
            Node<T> curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }

             
            curr.next = newNode;
          
            
            this.size++;
          
            return this.size;
        }

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

            this.size--;
        }

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

    }

}
      


