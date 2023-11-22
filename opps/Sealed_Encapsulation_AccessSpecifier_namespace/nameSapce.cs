using System;
namespace First
{
    class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello From first namespace");
        }
    }
}
namespace Second
{
    class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from Second namespace");
        }
    }
}

namespace Namesapce
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            Second.Hello h2 = new Second.Hello();
            h1.sayHello();
            h2.sayHello();
            Console.ReadKey();
        }
    }
}
