using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class DoublyLinkedList<T> : CircularLinkedList<T>
    {
        new public T this[int i]
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

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        new public int Count
        {
            get;
            private set;
        }

        new public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            // Сохранение узла head 
            LinkedListNode<T> temp = _head;

            // Указание нового значения начала списка 
            _head = node;

            // Установка указателя.     

            _head.Next = temp;

            if (Count == 0)
            {
                // Если список был пуст, то оба указателя указывают на новый узел.   

                _tail = _head;
            }
            else
            {
                // Реализация указателя на предыдущий узел
                // ДО:     head -------> 5 <-> 7 -> null
                // После:  head -> 3 <-> 5 <-> 7 -> null 

                temp.Previous = _head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;

                // До:    Head -> 3 <-> 5 -> null         
                // После: Head -> 3 <-> 5 <-> 7 -> null         
                // 7.Previous = 5   

                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }
        
        new public bool Remove(T item)
        {
            //Метод возвращает true, если элемент найден и удален.  

            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            // 1: Список пуст.     
            // 2: В списке один узел.     
            // 3: Если в списке много узлов:     
            //    a: Узел может быть первым.     
            //    b: Узел может быть последним или средним.  

            while (current != null)
            {
                // Head -> 3 -> 5 -> 7 -> null         
                // Head -> 3 ------> 7 -> null         
                if (current.Value.Equals(item))
                {
                    // Узел находится в середине или в конце списка              

                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        // Если это последний элемент списка - обновить _tail 

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        else
                        {
                            // ДО: Head -> 3 <-> 5 <-> 7 -> null                     
                            // ПОСЛЕ:  Head -> 3 <-------> 7 -> null  

                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;

                }
                previous = current;
                current = current.Next;
            }
            return false;

        }
        
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // ДО:     Head -> 3 <-> 5         
                // Посли:  Head -------> 5  

                _head = _head.Next;
                Count--;

                if (Count == 0)
                {
                    _tail = null;
                }
                else
                {
                    _head.Previous = null;
                }
            }
        }
        
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    // ДО: Head --> 3 <---> 7             
                    //         _tail = 7             
                    // ПОСЛЕ:  Head --> 3 --> null             
                    //         _tail = 3             

                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;

                }

                Count--;
            }
        }

        public void AddInsert(int index, T item)
        {
            LinkedListNode<T> newElement = new LinkedListNode<T>(item);

            //LinkedListNode<T> newOffice = new LinkedListNode<T>(of);
            LinkedListNode<T> temp = _head;

            //если список пустой полюбому зайдет сюда
            if (index == this.Count)
            {
                int i = 0;

                while (i != Count - 1)
                {
                    if (_head == null)
                    {
                        _head = newElement;
                        _tail = _head;
                        temp = _head;
                        temp.Previous = _head;
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
                if (index > this.Count - 1)
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

    }
}
