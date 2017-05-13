using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace Programming_4_semestr_3_lab
{
    class CircularLinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> _head;
        public LinkedListNode<T> _tail;

        public int Count
        {
            get;
            private set;
        }

        public T this[int i]
        {
            get
            {
                return this.GetAt(i);
            }
            set
            {
                SetAt(i, value);
            }
        }

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

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
        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            node.Next = _head;
            _head = node;
            if (Count == 0)
                _tail = _head;
            Count++;
        }
        
        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

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
        
        public bool Contains(T item)
        {
            LinkedListNode<T> current = _head;

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

        public T GetAt(int numberNode)
        {
            LinkedListNode<T> temp = Agregator(numberNode);

            return temp.Value;
        }

        private LinkedListNode<T> Agregator(int numberNode)
        {
            int i = 0;
            LinkedListNode<T> temp = _head;

            while (i < numberNode)
            {
                temp = temp.Next;
                i++;
            }
            return temp;
        }

        //public void SetAt (int numberNode, T a)
        //{
        //    int i = 0;
        //    LinkedListNode<T> temp = _head;

        //    while (i < numberNode)
        //    {

        //        temp = temp.Next;
        //        i++;
        //    }

        //    temp.Value = a;
        //}

        public void SetAt(int numberNode, T a)
        {
            LinkedListNode<T> temp = Agregator(numberNode);
            temp.Value = a;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
        
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        
        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public void AddInsert(int index, T item)
        {
            LinkedListNode<T> newElement = new LinkedListNode<T>(item);
            
            //LinkedListNode<T> newOffice = new LinkedListNode<T>(of);
            LinkedListNode<T> temp = _head;

            //если список пустой полюбому зайдет сюда
            if ( index==this.Count)
            {
                int i = 0;
                
                while (i != Count-1)
                {
                    if (_head == null)
                    {
                        _head = newElement;
                        _tail = newElement;
                        temp = _head;
                        break;
                    }
                    if (temp == null)
                    {
                        temp = _head;
                    }
                    else
                    {
                       temp = temp.Next;     
                    }
                    
                    i++;
                }

                temp.Next = newElement;

                this.Count++;
            }
            else
            {
                if (index > this.Count-1)
                {
                    if (index == this.Count)
                    {
                        newElement.Next = _tail;
                        _tail = newElement;
                        if (Count == 0)
                            _head = _tail;
                        Count++;
                    }
                    else
                    {
                        //здесь сделать добавление переменных
                        int i = 0;
                        //while (i != index)
                        //{
                        while (i != Count - 1)
                        {
                            //if (i>=Count-1)
                            //{
                            //    break;
                            //}
                            if (temp == null)
                            {
                                temp = _head;
                            }
                            else
                            {
                                temp = temp.Next;
                            }
                            //temp.Next = newElement;
                            i++;
                            
                        }
                        //temp.Next = newOffice; /*new Office();*/
                        //this.Count++;
                        //i++;
                        //}
                        //temp.Next = newElement;
                        temp.Next = newElement;
                        this.Count++;
                    }
                }
                //никита
                if (index < this.Count && index > 0)
                {
                    int i = 0;
                    while (i < index - 1)
                    {
                        temp = temp.Next;
                        i++;
                    }
                    newElement.Next = temp.Next;
                    temp.Next = newElement;
                    this.Count++;
                }
                else
                {
                    if (index == 0)
                    {
                        newElement.Next = temp;
                        this._head = newElement;
                        Count++;
                    }
                    //исключение - индекс отрицательный или больше размера. 
                }
                //никита
            }
        }

        public void RemoveInsert(int index, T item)
        {
            LinkedListNode<T> newElement = new LinkedListNode<T>(item);
            
            if (index == this.Count)
            {
                int i = 0;
                LinkedListNode<T> temp = _head;

                while (i != Count - 1)
                {
                    if (_head == null)
                    {
                        _head = newElement;
                        _tail = newElement;
                        temp = _head;
                        break;
                    }
                    if (temp == null)
                    {
                        temp = _head;
                    }
                    else
                    {
                        temp = temp.Next;
                    }

                    i++;
                }

                temp.Next = newElement;

                this.Count++;
            }
            else
            {
                if (index < this.Count && index > 0)
                {
                    int i = 0;
                    LinkedListNode<T> temp = _head;

                    while (i < index - 1)
                    {
                        temp = temp.Next;
                        i++;
                    }
                    newElement.Next = temp.Next;
                    temp.Next = newElement;
                    this.Count++;
                }
                else
                {
                    if (index == 0)
                    {
                        LinkedListNode<T> temp = _head;

                        newElement.Next = temp;
                        this._head = newElement;
                        Count++;
                    }
                    //исключение - индекс отрицательный или больше размера. 
                }
            }
        }
    }
}