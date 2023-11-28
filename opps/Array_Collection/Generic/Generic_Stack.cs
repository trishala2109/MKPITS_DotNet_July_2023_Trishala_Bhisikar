using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(11);
            s.Push(12);
            s.Push(13);
            s.Push(14);
            s.Push(15);

            Console.WriteLine("-------Push------");
            foreach(int num in s)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------Poping-------");
            s.Pop();
            foreach(int num in s)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
