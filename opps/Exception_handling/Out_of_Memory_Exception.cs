using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_of_Memory_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Trishala";
            string Subject = "Biology Course";
            Console.WriteLine("Name :- "+ Name + "\n"+ "Name of length :- " + Name.Length);

            StringBuilder sb = new StringBuilder(Name.Length,Name.Length);
            // StringBulider sb = new stringBulider(Capacity, Max capacity)
            try
            {
                sb.Append(Subject);
            }
            catch(Exception EE)
            {
                Console.WriteLine(EE.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
