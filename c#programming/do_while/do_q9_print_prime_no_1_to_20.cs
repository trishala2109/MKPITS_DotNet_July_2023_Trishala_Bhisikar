using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_q9_print_prime_no_1_to_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No. : 2");

            int num = 3;
            int counter = 2;
            int flag = 0;

            do
            {
                flag = 0;
                counter = 2;

                while (counter < num)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }
                if(flag == 0)
                {
                    Console.WriteLine("Prime No. : {0}", num);
                }
                num++;
            } while (num <= 20);
            Console.ReadKey();
        }
    }
}
