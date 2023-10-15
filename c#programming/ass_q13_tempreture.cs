using Microsoft.SqlServer.Server;
using System;

namespace ass_q13_tempreture
{
    internal class program
    {
        public static void Main()
        {
            int temp;

            Console.Write("Enter the Tempreture :");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>0 && temp <= 10)
            {
                Console.WriteLine("Very Cold Wether");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
            Console.ReadKey();
        }
    }

}

