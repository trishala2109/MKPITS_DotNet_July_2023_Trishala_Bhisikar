using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_Cpacitcy_and_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(52);
            myList.Add(6);
            myList.Add(9);
            myList.Add(4);
            myList.Add(7);
            myList.Add(10);
            myList.Add(63);
            myList.Add(78);
            myList.Add(30);
            myList.Add(20);

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count : " + myList.Count);
            Console.WriteLine("Capacity : " + myList.Capacity);
            Console.ReadLine();
        }
    }
}
