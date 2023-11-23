using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Collection_insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add(63);
            ar.Add(58);
            ar.Add(56);
            ar.Add(45);
            
            Console.WriteLine("---------Without Insert---------");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }

            Console.WriteLine("---------With Insert---------");
            ar.Insert(2, "trish");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }
            Console.ReadLine();
        }
    }
}
