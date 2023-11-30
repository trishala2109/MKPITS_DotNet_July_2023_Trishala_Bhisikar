using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Cast_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Trishala");
            sb.Append("Bhisikar");
            Console.WriteLine(sb.ToString());

            object obj = sb;
            Console.WriteLine(obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch (InvalidCastException ICE)
            {
                Console.WriteLine(ICE.ToString());
            }
            Console.ReadKey();
        }
    }
}
