using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    #region Task
    //Задание 6
    //Создайте интерфейс Space помещения здания.
    //Интерфейс должен соответствовать общей функциональности Flat и Office и
    //содержать следующие методы:
    // получения количества комнат,
    // изменения количества комнат,
    // получения площади,
    // изменения площади.
    //Классы, соответственно, должны реализовывать интерфейс (при необходимости
    //измените классы).
    //Рекомендуется использовать возможности рефакторинга среды разработки.
    #endregion
    interface ISpace
    {
        int GetNumberRoomOffice();//получение количества комнат

        void СhangeNumberRoomOffice(int room);//изменение кличества комнaт

        int GetAreaOffice();//получение площади

        void СhangeAreaOffice(int area);//изменение площади
    }
}
