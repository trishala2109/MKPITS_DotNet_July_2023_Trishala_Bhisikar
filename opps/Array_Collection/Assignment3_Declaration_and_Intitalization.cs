using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment1_Declaration_and_Intitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            foreach(int i in myList)
            {
                Console.WriteLine("Interget Number : " + i);
            }
            Console.ReadLine();
        }
    }
}
