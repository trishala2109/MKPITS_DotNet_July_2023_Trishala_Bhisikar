using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface_Declartion
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string errorMessage);
    }
    class ConsoleLogger : ILogger
    {
        public string LogMessage(string message)
        {
            return "This Message is Error Free";
        }
        public string LogError(string message)
        {
            return "This Message in some Error";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger i;
            i = new ConsoleLogger();
            
            string res= i.LogMessage("");
            Console.WriteLine(res);
            res=i.LogError("");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
