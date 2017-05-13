using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class OfficeFloor : IFloor
    {
        #region Task
        //Создайте класс OfficeFloor этажа офисного здания.
        //Работа класса должна быть основана на односвязном циклическом списке офисов с выделенной головой.
        //Номер офиса явно не хранится.

        //Создайте приватный метод получения узла по его номеру.
        //Создайте приватный метод добавления узла в список по номеру.
        //Создайте приватный метод удаления узла из списка по его номеру.

        //Конструктор может принимать количество офисов на этаже.
        //Конструктор может принимать массив офисов этажа.

        //Создайте метод получения количества офисов на этаже.
        //Создайте метод получения общей площади помещений этажа.
        //Создайте метод получения общего количества комнат этажа.
        //Создайте метод получения массива офисов этажа.
        //Создайте метод получения офиса по его номеру на этаже.

        //Создайте метод изменения офиса по его номеру на этаже и ссылке на обновленный офис.
        //Создайте метод добавления нового офиса на этаже по будущему номеру офиса.
        //Создайте метод удаления офиса по его номеру на этаже.
        //Создайте метод getBestSpace() получения самого большого по площади офиса этажа
        #endregion
        
        #region  Индексация
        public Office this[int i]
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

        public void SetAt(int numberNode, Office a)
        {

            LinkedListNode<Office> temp = Agregator(numberNode);
            temp.Value = a;
        }

        public Office GetAt(int numberNode)
        {
            if (numberNode > CLL.Count - 1)
            {
                return null;
            }
            LinkedListNode<Office> temp = Agregator(numberNode);

            return temp.Value;
        }

        private LinkedListNode<Office> Agregator(int numberNode)
        {
            int i = 0;
            LinkedListNode<Office> temp = CLL._head;

            while (i < numberNode)
            {
                temp = temp.Next;
                i++;
            }
            return temp;
        }

        #endregion//getat возвращает null если нет такого элемента 
        
        #region Конструкторы
        public OfficeFloor()
        {

        }// null

        public OfficeFloor(int numberOffice)
        {
            for (int i = 0; i < numberOffice; i++)
            {
                CLL.Add(new Office());
            }

        }//принемает количество офисов на этаже. 

        public OfficeFloor(Office[] numberOffice)
        {
            for (int i = 0; i < numberOffice.Length; i++)
            {
                CLL.Add(numberOffice[i]);
            }
        }//принемает массив офисов этажа. 
        #endregion

        CircularLinkedList<Office> CLL = new CircularLinkedList<Office>();

        private Office GetNode(int numberNode)
        {
            return CLL[numberNode];
        }//получения узла по его номеру. //или метод getat

        private void AddNode(int newNumberOffice,Office newOffice)
        {
            Office of = new Office();
            CLL.AddInsert(newNumberOffice, newOffice);
        }//добавления узла в список по номеру.
        
        private void RemoveNode(int numberNode)
        {
            //CLL.SetAt(numberNode,null);//так не работает
        }//удаления узла из списка по его номеру. null
        

        public int GetNumberOffice()
        {
            return CLL.Count;
        }//получения количества офисов на этаже.

        public int GetAreaFloor()
        {
            int TotalArea = 0;
            foreach (var item in CLL)
            {
                TotalArea += item.area;
            }
            return TotalArea;
        }//получения общей площади помещений этажа.

        public int GetTotalRoomFloor()
        {
            int count = 0;
            foreach (var item in CLL)
            {
                count += item.room;
            }
            return count;
        }//получения общего количества комнат этажа.

        public Office[] GetArrayFloor()
        {
            Office[] array = new Office[CLL.Count];
            CLL.CopyTo(array, 0);
            return array;
        }//получения массива офисов этажа. 
        
        public Office GetOffice(int numberOffice)
        {
            return GetNode(numberOffice);
        }//получения офиса по его номеру на этаже.

        public void ChangeOffice(int numberOffice, Office obj)
        {
            CLL.SetAt(numberOffice, obj);
        }//изменения офиса по его номеру на этаже и ссылке на обновленный офис.
            
        public void AddOffice(int futureNumberOffice)
        {
            AddNode(futureNumberOffice, new Office());
        }//добавления нового офиса на этаже по будущему номеру офиса.
        public void AddOffice(int futureNumberOffice, Office office)
        {
            AddNode(futureNumberOffice, office);
        }//добавления нового офиса на этаже по будущему номеру офиса.

        public void RemoveOffice(int numberOffice)
        {

        }//удаления офиса по его номеру на этаже. null

        public Office GetBestSpace()
        {
            int maxArea = 0;
            Office of = null;
            foreach (var item in CLL)
            {
                if (item.area > maxArea)
                {
                    maxArea = item.area;
                    of = item;
                }
            }
            return of;
        }//получения самого большого по площади офиса этажа

        public void Display()
        {
            Console.WriteLine();
            foreach (var word in CLL)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = " Количество оффисов: " + CLL.Count + "\n";

            return s;
        }
    }
}
