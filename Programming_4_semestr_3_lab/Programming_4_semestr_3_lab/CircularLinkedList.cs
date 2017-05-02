using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4_semestr_3_lab
{
    class CircularLinkedList<Office> : IEnumerable<Office>
    {
        public LinkedListNode<Office> _head;
        public LinkedListNode<Office> _tail;

        public int Count
        {
            get;
            private set;
        }
        
        public void Add(Office value)
        {

            LinkedListNode<Office> node = new LinkedListNode<Office>(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }

            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        public void AddFirst(Office value)
        {
            LinkedListNode<Office> node = new LinkedListNode<Office>(value);
            node.Next = _head;
            _head = node;
            if (Count == 0)
                _tail = _head;
            Count++;
        }
        
        public bool Remove(Office item)
        {
            LinkedListNode<Office> previous = null;
            LinkedListNode<Office> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item)) 
                {

                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head.Next;             

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        
        public bool Contains(Office item)
        {
            LinkedListNode<Office> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }
        
        public IEnumerator<Office> GetEnumerator()

        {
            LinkedListNode<Office> current = _head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Office>)this).GetEnumerator();

        }
        
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        
        public void CopyTo(Office[] array, int arrayIndex)
        {
            LinkedListNode<Office> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }
    }
}