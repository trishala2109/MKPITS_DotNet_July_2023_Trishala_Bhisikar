using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("Java");
            li.Add("C#");
            li.Add("Php");
            li.Add("HTML");

            Console.WriteLine("----------Total Courses--------");
            Console.WriteLine(li.Count);
            Console.WriteLine("------------------");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------After Removing--------");
            li.Remove("HTML");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-------------Inster Courses----------");
            li.Insert(1,"Python");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-------------Sorting----------");
            li.Sort();
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
