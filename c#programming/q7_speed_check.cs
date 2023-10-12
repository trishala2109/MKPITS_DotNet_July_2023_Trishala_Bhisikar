using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7_kilomete_per_hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metres, hours, mint, sec;
            double metressec, kmhour, milhour, total;
            Console.WriteLine("Input distance (metres):");
            metres = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input TimeSec(hours):");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input TimeSce(minutes):");
            mint = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input TimeSec(seconds):");
            sec = Convert.ToDouble(Console.ReadLine());

            total= (hours * 3600) + (mint * 60) + sec;   //Total time in second
            metressec = metres / total;  //speed in meters per second
            kmhour = (metres / 1000) / (total / 3600);  //speed in kilometers per hours
            milhour = (metres / 1609) / (total / 3600);  //speed in miles per hour

            Console.WriteLine("Your speed in metres/sec is =" + metressec);
            Console.WriteLine("Your speed in km/h is =" + kmhour);
            Console.WriteLine("Your speed in miles/h is =" + milhour);

            Console.ReadKey();
        }
    }
}
