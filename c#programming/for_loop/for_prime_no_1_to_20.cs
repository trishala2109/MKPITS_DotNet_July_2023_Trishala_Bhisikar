using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No. 2");

            int num, counter = 2, flag = 0;

            for( num = 3; num <= 20; num++ )
            {
                flag = 0;
                counter = 2;
                while( counter < num )
                {
                    if( num % counter == 0 )
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }
                if ( flag == 0)
                {
                    Console.WriteLine("Prime No. {0}", num);
                }
            }
            Console.ReadKey();
        }
    }
}
