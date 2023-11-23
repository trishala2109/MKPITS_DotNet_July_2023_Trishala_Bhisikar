using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Collection_Remove_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Arti");
            ar.Add("Dilip");
            ar.Add("Firangi");
            ar.Add("Shub");
            ar.Add(5632);

            Console.WriteLine("---------Without removing----------");
            foreach(object obj in ar)
            {
                Console.WriteLine("Name " + obj);
            }

            ar.Remove("Dilip");
            Console.WriteLine("---------With removing----------");
            foreach (object obj in ar)
            {
                Console.WriteLine("Name " + obj);
            }
            Console.ReadLine();
        }
    }
}
