using System;
using First;
using Second;
namespace First
{
    class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("namespace from hello");
        }
    }
}
namespace Second
{
    class welcome
    {
        public void SayHello()
        {
            Console.WriteLine("namespace from welcome");
        }
    }
}

namespace using_keyword_with_namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h1 = new Hello();
            welcome w1 = new welcome();
            h1.SayHello();
            w1.SayHello();
            Console.ReadLine();
        }
    }
}
