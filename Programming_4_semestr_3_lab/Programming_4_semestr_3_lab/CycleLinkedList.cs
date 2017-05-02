using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class CycleLinkedListNode
    {
        public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
        {
            public LinkedListNode<T> _head;
            public LinkedListNode<T> _tail;

            public int Count
            {
                get;
                private set;
            }

            #region Метод Add добавляет элемента в конец связаного списока

            // 1) Создание нового узла 
            // 2) Нахожение последнего узла 
            // 3) Создание указателя с предыдущего узла на новый.!!!!

            // Когда указатель указывает на начало списка, то при добавлении элемента приходится перебирать все его узлы, что бы достичь конечного, 
            // при этом степень роста алгоритма составляет О(n). Лудше когда указатель установлен на конец списка, тогда при добавлении элемента, стпень
            // роста равна константе О(1).   

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
            
            #endregion

            #region Метод Remove удаляет из списка указанный элемент.

            //Метод возвращает true, если элемент найден и удален.  

            public bool Remove(T item)
            {
                LinkedListNode<T> previous = null;
                LinkedListNode<T> current = _head;

                while (current != null)
                {
                    if (current.Value.Equals(item)) // Определяет, равен ли заданный объект текущему объекту.
                    {

                        if (previous != null)
                        {
                            // Смена указателя Next. из  предыдущего на следующий  

                            // ДО:
                            // head
                            // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+
                            // | 12  |  *---+--->| 15  |   *--+--->| 20  |  *--+--->| 25  |  *--+--->
                            // +-----+------+    +-----+------+    +-----+-----+    +-----+-----+

                            previous.Next = current.Next;

                            // ПОСЛЕ:
                            // head
                            // +-----+------+    +-----+------+                     +-----+-----+
                            // | 12  |  *---+--->| 15  |   *--+-------------------->| 25  |  *--+--->
                            // +-----+------+    +-----+------+                     +-----+-----+

                            // Определение конца списка

                            if (current.Next == null)
                            {
                                _tail = previous;
                            }
                        }
                        else
                        {
                            // Удаление первого элемента списка

                            _head = _head.Next;

                            // Если список пуст и был удален единственный элемент                 

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

            #endregion

            #region Метод Contains возвращает значение true, если элемент пренадлежит списку

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

            #endregion

            #region Метод получает нумератор для колекции

            // Возвращает экземпляр интерфейса IEnumerator <T>, который позволяет пронумеровать элементы связанного списка, 
            // от первого до последнего.

            public System.Collections.Generic.IEnumerator<T> GetEnumerator()

            {
                LinkedListNode<T> current = _head;

                while (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
            }


            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<T>)this).GetEnumerator();

            }


            #endregion

            #region Метод Clear очищает список

            public void Clear()
            {
                // Метод Clear очищет список, устанавливая _head и _tail в null. Достаточно удалить ссылки на элементы и сборщик мусора,
                // самостоятельно сотрет список.

                _head = null;
                _tail = null;
                Count = 0;
            }


            #endregion

            #region Метод CopyTo копирует содержимое списка в массив

            public void CopyTo(T[] array, int arrayIndex)
            {
                LinkedListNode<T> current = _head;

                while (current != null)
                {
                    array[arrayIndex++] = current.Value;
                    current = current.Next;
                }
            }

            #endregion

        }
    }
}
