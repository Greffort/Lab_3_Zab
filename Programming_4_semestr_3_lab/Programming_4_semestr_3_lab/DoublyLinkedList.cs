using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class DoublyLinkedList<T> : CircularLinkedList<T>
    {
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


        #region Метод AddFirst добавляет новый элемент в начало списка

        // В то время как в односвязный список добавлять элементы можно только в конец, двухсвязный список позволяет добавлять
        // их и в начало. Для этого существует метод AddFirst.  

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
        #endregion

        #region Метод AddLast добавляет новый элемент в конец списка

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

        #endregion

        #region Метод Remove удаляет из списка указанный элемент.

        //Метод возвращает true, если элемент найден и удален.  

        new public bool Remove(T item)
        {
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
        #endregion

        #region Метод RemoveFirst удаляет первый элемент из списка

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


        #endregion

        #region Метод RemoveLast удалеят последний элемента из списка

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

        #endregion
    }
}
