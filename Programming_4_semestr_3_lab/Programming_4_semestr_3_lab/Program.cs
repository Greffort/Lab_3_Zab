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
            
            OfficeFloor OF = new OfficeFloor();
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

            OF.AddNode(O1);
            OF.AddNode(O2);
            OF.AddNode(O3);
            OF.AddNode(O4);

            OF.Display();

            Console.WriteLine(OF.GetOffice(3));
            
            OF.ChangeOffice(3, O5);

            OF.Display();

            OF.RemoveOffice(2);

            OF.Display();




















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
