using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_nested2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int innercounter, outercounter;
            for (outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (innercounter = 1; innercounter <= 3; innercounter++)
                {
                    Console.Write(innercounter + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
