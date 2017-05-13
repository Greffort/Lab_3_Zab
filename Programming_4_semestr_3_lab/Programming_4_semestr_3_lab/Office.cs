using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class Office : ISpace
    {
        #region Task
        //Создайте класс Office офиса офисного здания.
        //Офис не хранит свой номер.
        //Разные офисы могут иметь разные площади.
        //Разные офисы могут иметь разное количество комнат.

        //Конструктор по умолчанию создает офис из 1 комнаты площадью 250 кв.м. (константы)
        //Конструктор может принимать площадь офиса(создается офис с 1 комнатой).
        //Конструктор может принимать площадь офиса и количество комнат.

        //Создайте метод получения количества комнат в офисе.
        //Создайте метод изменения количества комнат в офисе.
        //Создайте метод получения площади офиса.
        //Создайте метод изменения площади офиса.
        #endregion

        public int room { get; set; }
        public int area { get; set; }
        

        public Office()
        {
            this.room = 1;
            this.area = 250;
        }

        public Office(int area)
        {
            this.room = 1;
            this.area = area;
        }

        public Office(int area, int room)
        {
            this.room = room;
            this.area = area;
        }
        

        public int GetNumberRoomOffice()
        {
            return this.room;
        }//получение количества комнат

        public void СhangeNumberRoomOffice(int room)
        {
            this.room = room;
        }//изменение кличества комнaт

        public int GetAreaOffice()
        {
            return this.area;
        }//получение площади

        public void СhangeAreaOffice(int area)
        {
            this.area = area;
        }//изменение площади

        public override string ToString()
        {
            string s = "Площадь: " + area +" Количество комнат: "+room + "\n";
            
            return s;
        }

    }
}