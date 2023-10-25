using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q1_table_method
{
    internal class Program
    { 
        static int table(int num)
        {
            int counter, res=0;

            for(counter = 1; counter <= 10; counter++)
            {
                res = num * counter;
                Console.WriteLine(num + "*" + counter + "=" + res + "\n");
            }
            return res;
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number :- ");
            number = Convert.ToInt32(Console.ReadLine());

            int result = table(number);
            

            Console.ReadKey();
        }
    }
}
