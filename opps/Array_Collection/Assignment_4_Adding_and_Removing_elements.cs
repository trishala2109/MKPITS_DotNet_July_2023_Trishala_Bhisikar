using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_4_Adding_and_Removing_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.RemoveAt(2);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
