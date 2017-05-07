using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class LinkedListNode<T>
    {
        public LinkedListNode()
        {

        }

        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value
        {
            get;
            internal set;
        }
          
        public LinkedListNode<T> Next
        {
            get;
            internal set;
        }

        public LinkedListNode<T> Previous
        {
            get;
            internal set;
        }
    }
}