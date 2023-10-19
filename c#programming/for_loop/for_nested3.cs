using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_nested3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int innercounter, outercounter;
            for (outercounter = 1; outercounter <= 5; outercounter++)
            {
                for (innercounter = 1; innercounter <= outercounter; innercounter++)
                {
                    Console.Write(" * \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

