using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("11", "Vada Pav");
            sl.Add("85", "Pav Bhaji");
            sl.Add("32", "Masala Dosa");
            sl.Add("04", "Panner Tikka");
            sl.Add("46", "Dal Bati");
            sl.Add("49", "Raj kachori");

            ICollection key = sl.Keys;
            Console.WriteLine("Order number and Ordered Menue");
            Console.WriteLine("Order No." + "  " + "Item");
            foreach(string k in key)
            {
                Console.WriteLine(k + "        : " + sl[k]);
            }
            Console.ReadLine();
        }
    }
}
