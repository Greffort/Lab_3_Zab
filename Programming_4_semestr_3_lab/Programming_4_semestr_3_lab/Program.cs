using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4_semestr_3_lab
{
    class Program 
    {
        static void Main(string[] args)
        {
            Office O1 = new Office(100, 1);
            Office O2 = new Office(200, 2);
            Office O3 = new Office(300, 3);
            Office O4 = new Office(400, 4);
            Office O5 = new Office(100500, 100500);
            Office O6 = new Office();


            OfficeFloor OF = new OfficeFloor();
            OfficeFloor OF1 = new OfficeFloor(1);
            OfficeFloor OF2 = new OfficeFloor(2);
            OfficeFloor OF3 = new OfficeFloor(3);
            OfficeFloor OF4 = new OfficeFloor(4);
            OfficeFloor OF5 = new OfficeFloor(5);
            OfficeFloor OF6 = new OfficeFloor(100500);


            OfficeBuilding OB = new OfficeBuilding();


            CircularLinkedList<Office> CLL = new CircularLinkedList<Office>();
            DoublyLinkedList<OfficeFloor> DLL = new DoublyLinkedList<OfficeFloor>();
            //DLL.GetAt(2);

            //OF.Display();
            //OF.Add(O2);
            //OF.Add(O3);
            //CLL.Add(O1);
            //CLL.Add(O2);
            //CLL.Add(O3);
            //CLL.Add(O4);
            //OF.AddOffice(0);
            OF.AddOffice(0, O1);
            OF.AddOffice(1, O2);
            OF.AddOffice(2, O3);
            OF.AddOffice(3, O4);
            OF.AddOffice(3, O5);
            OF.AddOffice(6, O5);
            ////OF[0] = O5;
            //CLL.AddInsert(6, O5, O6);
            ////Console.WriteLine(OF[0]);
            ////Console.WriteLine(OF[1]);
            ////Console.WriteLine(OF[2]);
            ////Console.WriteLine(OF[3]);
            ////Console.WriteLine(OF[4]);
            ////Console.WriteLine(OF[5]);
            ////Console.WriteLine(OF[6]);
            ////Console.WriteLine(OF[7]);
            ////Console.WriteLine(OF[8]);
            //OF.Display();

            Console.WriteLine(OF.GetNumberOffice());
           

            OB.AddOfficeFloor(0, OF1);
            OB.AddOfficeFloor(1, OF2);
            OB.AddOfficeFloor(2, OF3);
            OB.AddOfficeFloor(3, OF4);
            OB.AddOfficeFloor(4, OF5);
            OB.AddOfficeFloor(5, OF6);

            Console.WriteLine(OB.GetNumberOffice());

            Console.WriteLine(OB[0]);
            Console.WriteLine(OB[1]);
            Console.WriteLine(OB[2]);
            Console.WriteLine(OB[3]);
            Console.WriteLine(OB[4]);
            Console.WriteLine(OB[5]);

            //Console.WriteLine(CLL[5]);


            //foreach (var VARIABLE in CLL)
            //{
            //    Console.WriteLine(VARIABLE);
            //}


            //OF.ChangeOffice(3, O5);

            //OF.Display();

            //OF.RemoveOffice(2);

            //OF.Display();




















            Console.ReadKey();






            //пример использования от хохлов

            //CircularLinkedList<string> circularList = new CircularLinkedList<string>();

            //circularList.Add("Tom");
            //circularList.Add("Bob");
            //circularList.Add("Alice");
            //circularList.Add("Jack");
            //foreach (var item in circularList)
            //{
            //    Console.WriteLine(item);
            //}

            //circularList.Remove("Bob");
            //Console.WriteLine("\n После удаления: \n");
            //foreach (var item in circularList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
