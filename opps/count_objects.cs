using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_objects
{
    class countobjects
    {
        public int ID;
        public string Name;
        public static int cnt = 0;

        public countobjects(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            cnt++;
          
        }
        public void display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " +  Name);
            Console.WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            countobjects c1 = new countobjects(12, "object 1");
            c1.display();

            countobjects c2 = new countobjects(123, "object 2");
            c2.display();

            Console.WriteLine("Total Objects are: " + countobjects.cnt);

            Console.ReadKey();
        }
    }
}
