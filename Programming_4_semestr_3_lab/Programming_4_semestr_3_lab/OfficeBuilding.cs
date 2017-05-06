using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class OfficeBuilding : IBuilding
    {
        #region Task
        //Создайте класс OfficeBuilding офисного здания.
        //Работа класса должна быть основана на двусвязном циклическом списке этажей с выделенной головой.
        //Номер офиса явно не хранится.
        //Нумерация офисов в здании сквозная и начинается с нуля.

        //Конструктор может принимать количество этажей и массив количества офисов по этажам.
        //Конструктор может принимать массив этажей офисного здания.

        //Создайте приватный метод получения узла по его номеру.
        //Создайте приватный метод добавления узла в список по номеру.
        //Создайте приватный метод удаления узла из списка по его номеру.

        //Создайте метод получения общего количества этажей здания.
        //Создайте метод получения общего количества офисов здания.
        //Создайте метод получения общей площади помещений здания.
        //Создайте метод получения общего количества комнат здания.
        //Создайте метод получения массива этажей офисного здания.
        //Создайте метод получения объекта этажа, по его номеру в здании.
        //Создайте метод получения объекта офиса по его номеру в офисном здании.

        //Создайте метод изменения этажа по его номеру в здании и ссылке на обновленный этаж.
        //Создайте метод изменения объекта офиса по его номеру в доме и ссылке типа офиса.
        //Создайте метод добавления офиса в здание по номеру офиса в здании и ссылке на офис.
        //Создайте метод удаления офиса по его номеру в здании.
        //Создайте метод getBestSpace() получения самого большого по площади офиса здания.
        //Создайте метод получения отсортированного по убыванию площадей массива офисов.
        #endregion
        DoublyLinkedList<OfficeFloor> DLL = new DoublyLinkedList<OfficeFloor>();

        int[] countOfficeOnFloors;

        OfficeBuilding[] array;


        public OfficeBuilding()
        {

        }

        public OfficeBuilding(int CountFloor, int[] countOfficeOnFloors)
        {
            this.countOfficeOnFloors = countOfficeOnFloors;
        }//количество этажей и массив количества офисов по этажам.

        public OfficeBuilding(OfficeBuilding[] array)
        {
            this.array = array;
        }//массив этажей офисного здания


        private void GetNode(int numberNode)
        {
            DLL.GetAt(numberNode);
        }//получения узла по его номеру.

        private void AddNode(int numberNode)
        {


        }//добавления узла в список по номеру. null

        private void RemoveNode(int numberNode)
        {

        }//удаления узла из списка по его номеру. null


        public int GetNumberFloor()
        {
            return DLL.Count;
        }//получения общего количества этажей здания.

        public int GetNumberOffice()
        {
            int TotalArea = 0;
            //foreach (var item in DLL)
            //{
            //    TotalArea += item.;
            //}
            return TotalArea;
        }//получения общего количества офисов здания. null

        public int GetTotalAreaFloor()
        {
            int count = 0;
            foreach (var item in DLL)
            {
                int i = item.GetAreaFloor();
                count += i;
            }
            return count;
        }//получения общей площади помещений здания.

        public int GetTotalRoomFloor()
        {
            int count = 0;
            foreach (var item in DLL)
            {
                int i = item.GetTotalRoomFloor();
                count += i;
            }
            return count;
        }//получения общего количества комнат здания. 

        public OfficeFloor[] GetArrayFloor()
        {
            OfficeFloor[] array = new OfficeFloor[DLL.Count];
            DLL.CopyTo(array, 0);
            return array;
        }//получения массива этажей офисного здания.

        public OfficeFloor GetFloor(int numberOfficeInBuilding)
        {
            return DLL.GetAt(numberOfficeInBuilding);
        }//получения объекта этажа, по его номеру в здании. null

        public int GetOffice(int numberOfficeInBuilding)
        {
            
            return DLL.Count;
        }//получения объекта офиса по его номеру в офисном здании. null


        public void ChangeFloor(int numberFloorInBuilding/*, ссылка на обновленный этаж*/)
        {

        }//изменения этажа по его номеру в здании и ссылке на обновленный этаж. null

        public void ChangeOffice(int numberFloorInBuilding/*, ссылка на тип оффиса*/)
        {

        }//изменения объекта офиса по его номеру в доме и ссылке типа офиса. null

        public void AddOffice(int numberOfficeInBuilding/*, ссылка на оффис*/)
        {

        }//добавления офиса в здание по номеру офиса в здании и ссылке на офис. null

        public void RemoveOffice(int numberOfficeInBuilding)
        {

        }//удаления офиса по его номеру в здании. null

        public void RemoveOffice()
        {

        }//удаления офиса из здания. null требует интерфейс

        //public Office getBestSpace(CircularLinkedList<Office> List)
        //{
        //    int maxArea = 0;
        //    Office of = null;
        //    foreach (var item in List)
        //    {
        //        if (item.area > maxArea)
        //        {
        //            maxArea = item.area;
        //            of = item;
        //        }
        //    }
        //    return of;
        //}//получения самого большого по площади офиса здания. null

        public Office getBestSpace()
        {
            //int maxArea = 0;
            Office of = null;
            //foreach (var item in DLL)
            //{
            //    if (item.area > maxArea)
            //    {
            //        maxArea = item.area;
            //        of = item;
            //    }
            //}
            return of;
        }//получения самого большого по площади офиса здания. null требует интерфейс

        //Создайте метод получения отсортированного по убыванию площадей массива офисов. null





        public void Display()
        {
            Console.WriteLine();
            foreach (var word in DLL)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
