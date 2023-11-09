using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rate_of_intrest
{
    class ROI
    {
        public int ID;
        public string Name;
        public static float Rateofint = 8.8f;

        public ROI(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Rate of Intrest: " + Rateofint);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ROI r1 = new ROI(123, "Sujit");
            r1.display();

            ROI r2 = new ROI(12, "sahil");
            r2.display();

            Console.ReadKey();
        }
    }
}
