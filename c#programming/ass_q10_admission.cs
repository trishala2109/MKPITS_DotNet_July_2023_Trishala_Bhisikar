using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q10_admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maths, phy, che, total,result;
            Console.Write("Input the marks obtained in Mathematics :");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Physics :");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            che = Convert.ToInt32(Console.ReadLine());

            total = maths + phy + che;
            result = maths + total;

            if(maths >= 65 && phy >= 55 && che >= 50)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
