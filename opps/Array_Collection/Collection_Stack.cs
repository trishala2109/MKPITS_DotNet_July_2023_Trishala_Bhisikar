using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("Amit");
            st.Push("Prit");
            st.Push("Shikha");
            st.Push("Leela");

            Console.WriteLine("-------------Current Collection-------------");
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
            st.Pop();
            Console.WriteLine("-------------After Poping Collection-------------");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
