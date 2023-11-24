using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Pav Bhaji");
            q.Enqueue("SevPuri");
            q.Enqueue("Shole Bhature");
            q.Enqueue("Aalu Bhaji");
            q.Enqueue("Rasmalai");

            Console.WriteLine("----------Before Enqueue-----------");
            foreach(string k in q)
            {
                Console.WriteLine("Items : " + k);
            }

            q.Dequeue();
            Console.WriteLine("----------After Dqueue-----------");
            foreach (string k in q)
            {
                Console.WriteLine("Items : " + k);
            }
            Console.ReadLine();
        }
    }
}
