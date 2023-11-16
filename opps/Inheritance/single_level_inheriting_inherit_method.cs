using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinle_level_inheriting_inherit_method
{
    class Car
    {
        public void Start()
        {
            Console.WriteLine("Car is Starting");
        }
    }
    class Swift : Car
    {
        public void MusicStart()
        {
            Console.WriteLine("Car Music is Starting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Swift s = new Swift();
            s.Start();
            s.MusicStart();
            Console.ReadKey();
        }
    }
}
