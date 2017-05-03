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
            Office O1 = new Office(100, 8);
            Office O2 = new Office(11,1);
            Office O3 = new Office(300, 2);
            
            OfficeFloor OF = new OfficeFloor();

            //CLL.Add(O1);
            //CLL.Add(O2);
            //CLL.Add(O3);

            //OF.AddNode(0);

            OF.Display();
            //OF.Add(O2);
            //OF.Add(O3);
            
            
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
