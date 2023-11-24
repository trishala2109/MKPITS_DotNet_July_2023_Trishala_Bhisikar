using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1999", "DDLJ");
            ht.Add("2000", "Tal");
            ht.Add("2018", "YJHD");
            ht.Add("2022", "Bharmashtr");
            ht.Add("2013", "KGF");

            if(ht.ContainsValue("Pathan"))
            {
                Console.WriteLine("Add this : ");
            }
            else
            {
                ht.Add("2023","Pathan");
            }

            ICollection key = ht.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + " : " + ht[s]);
            }
            Console.ReadLine();
        }
    }
}
