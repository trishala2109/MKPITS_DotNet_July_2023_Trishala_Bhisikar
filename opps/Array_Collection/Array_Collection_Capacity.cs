using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Collection_Capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Aarti");
            ar.Add("Pooja");
            ar.Add("Dilip");
            ar.Add("Shukla");
            ar.Add("Mit");

            foreach (object obj in ar)
            {
               
                Console.WriteLine("Student Name : " + obj);
                
            }
            Console.WriteLine("Capacity : " + ar.Capacity);
            Console.WriteLine("Count : " + ar.Count);
            Console.ReadLine();
        }
    }
}

