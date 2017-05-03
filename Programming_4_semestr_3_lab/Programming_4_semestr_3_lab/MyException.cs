using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programming_4_semestr_3_lab
{
    #region Task
    //    Задание 4
    //Опишите следующие классы ошибок.

    //Ошибка выхода за границы номеров помещений
    //SpaceIndexOutOfBoundsException (необъявляемое исключение, расширяет
    //IndexOutOfBoundsException).

    //Ошибка выхода за границы номеров этажей FloorIndexOutOfBoundsException
    //(необъявляемое, расширяет IndexOutOfBoundsException).

    //Ошибка некорретной площади помещения InvalidSpaceAreaException
    //(необъявляемое, расширяет IllegalArgumentException).

    //Ошибка некорретного количества комнат в помещении
    //InvalidRoomsCountException(необъявляемое исключение, расширяет
    //IllegalArgumentException).

    //Измените имеющиеся классы так, чтобы они корректно обрабатывали возможные
    //ошибки и выбрасывали соответствующие исключения.
    #endregion
    class MyException : Exception
    {



    }
}
