using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> li = new Dictionary<string, string>();
            li.Add("D", "Dosa");
            li.Add("PB", "PavBhaji");
            li.Add("PT","Panner Tikka");

            Console.WriteLine("Total Order is : {0}", li.Count);

            Console.WriteLine("------Keys--------");
            List<string> keys = new List<string>(li.Keys);

            foreach(string key in keys)
            {
                Console.WriteLine("{0}",key);
            }

            Console.WriteLine("-------Value-------");
            List<string> vals= new List<string>(li.Values);

            foreach (string val in vals)
            {
                Console.WriteLine("{0}", val);
            }

            Console.WriteLine("--------Value and Keys---------");
            foreach(KeyValuePair <string,string> kv in li)
            {
                Console.WriteLine("Oreder No. {0}  Items {1}" , kv.Key, kv.Value);
            }
            Console.ReadLine();
        }
    }
}
