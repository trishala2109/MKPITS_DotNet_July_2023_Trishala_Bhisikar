using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> li = new LinkedList<string>();
            
            Console.WriteLine("------Adding Last-------");
            li.AddLast("Java");
            li.AddLast("C#");
            li.AddLast("C++");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------Adding First-------");
            li.AddFirst("Python");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------AddBefore--LinkListNode-----");
            LinkedListNode<string> node = li.FindLast("HTML");
            li.AddBefore(node,"Bootstrap");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------AddAfter--LinkListNode-----");
            li.FindLast("C#");
            li.AddAfter(node, "Bootstrap");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }
}
