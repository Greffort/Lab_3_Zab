﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    #region Task
    //    Задание 7
    //Создайте интерфейс Floor этажа здания, работающий со ссылками типа Space.Интерфейс должен соответствовать общей функциональности DwellingFloor и
    //OfficeFloor и должен содержать следующие методы:

    // получения количества помещений на этаже,
    // получения общей площади помещений на этаже,
    // получения общего количества комнат в помещениях этажа,
    // получения массива всех помещений этажа,
    // получения помещения по его номеру,
    // изменения помещения по его номеру и ссылке на новое помещение,
    // вставки помещения по его номеру и ссылке на новое помещение,
    // удаления помещения по его номеру,
    // получения лучшего помещения на этаже.                                                 <---- <---- <---- <---- <---- <---- ????

    //Классы, соответственно, должны реализовывать интерфейс и работать со ссылками типа
    //Space(с возможностью, например, добавить на жилой этаж офисное помещение).
    //Рекомендуется использовать возможности рефакторинга среды разработки.
    #endregion
    interface IFloor /*: ISpace*/
    {
        int GetNumberOffice();//получения количества помещений на этаже.

        int GetAreaFloor();//получения общей площади помещений этажа.

        int GetTotalRoomFloor();//получения общего количества комнат этажа.

        Office[] GetArrayFloor();//получения массива офисов этажа. 

        Office GetOffice(int numberOffice);//получения офиса по его номеру на этаже.

        void ChangeOffice(int numberOffice, Office obj);//изменения офиса по его номеру на этаже и ссылке на обновленный офис.

        void AddOffice(int numberNode/*,  ссылка на новое помещение*/ );//вставки помещения по его номеру и ссылке на новое помещение,

        void RemoveOffice(int numberOffice);//удаления офиса по его номеру на этаже .
        
    }
}
