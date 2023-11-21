using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Multiple_Interface
{
    interface IReadable
    {
        void ReadData();
        string WriteData(string data);
    }
    interface IWritable
    {
        void ReadData();
        string WriteData(string data);
    }
    class FileHandler : IReadable,IWritable
    {
        public void ReadData()
        {
            Console.WriteLine("This book was be readable");
        }
        public string WriteData(string data)
        {
            return "The book is writing ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler f;
            f = new FileHandler();

            f.ReadData();
            string res = f.WriteData("");
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
