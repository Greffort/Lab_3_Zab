using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class LinkedListNode<Office>
    {  
        public LinkedListNode(Office value)
        {
            Value = value;
        }

        public Office Value
        {
            get;
            internal set;
        }
          
        public LinkedListNode<Office> Next
        {
            get;
            internal set;
        }
    }
}
