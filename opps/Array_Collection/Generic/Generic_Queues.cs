using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Amit");
            q.Enqueue("Sumit");
            q.Enqueue("Ram");
            q.Enqueue("Sham");

            Console.WriteLine("---------Enqueue---------");
            foreach(string s in q)
            {
                Console.WriteLine("Name : " + s);
            }

            Console.WriteLine("---------Dequeue---------");
            q.Dequeue();
            foreach (string s in q)
            {
                Console.WriteLine("Name : " + s);
            }

            Console.ReadLine();
        }
    }
}
