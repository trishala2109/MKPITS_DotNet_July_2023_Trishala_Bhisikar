using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q9_print_prime_no_1_to_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No. 2");
            int  number = 3, counter = 2, flag = 0;

            while (number <= 20)
            {
                flag = 0;
                counter = 2;
                while (counter < number)
                {
                    if (number % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }
                
                if (flag == 0)
                {
                    Console.WriteLine("Prime NO. {0}",number);
                }
                number++;
            }

            Console.ReadKey();
        }
    }
}

