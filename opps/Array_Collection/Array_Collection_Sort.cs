using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Collection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("Trish");
            ar.Add("Pooja");
            ar.Add("Leela");
            ar.Add("Arti");
           
           Console.WriteLine("---------Without Sorting---------");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }

            Console.WriteLine("---------With Sorting---------");
            ar.Sort();
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }
            Console.ReadLine();
        }
    }
}
