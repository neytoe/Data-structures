using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    //This class holds the data to be stored in the list
    // and also holds the reference to the next node in the list
     public class Node<T>
    {
        public T data; //data of the node

        public Node<T> next;// reference to the next node in the list

        /*constructor takes in the data and a node,
        which is a refernce to the next node */
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next; ;
            
        }

        public  T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
       
    }
    
}
