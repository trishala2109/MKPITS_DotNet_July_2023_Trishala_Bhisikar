using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int innercounter, outercounter;
            for (outercounter = 1; outercounter <=5; outercounter++)
            {
                for (innercounter =1; innercounter <=5; innercounter++)
                {
                    Console.Write(outercounter + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
