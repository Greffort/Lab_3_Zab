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

            OfficeFloor OF = new OfficeFloor();
            CircularLinkedList<Office> CLL = new CircularLinkedList<Office>();
          
            

            

            


            //OF.Display();
            //OF.Add(O2);
            //OF.Add(O3);
            
            
            

            CLL.Add(O1);
            CLL.Add(O2);
            CLL.Add(O3);
            CLL.Add(O4);

            CLL[3] = O1;

            Console.WriteLine("Саня-ленивая жопа, устал");
            Console.WriteLine(CLL[3].ToString());


            OF.AddNode(4);

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
