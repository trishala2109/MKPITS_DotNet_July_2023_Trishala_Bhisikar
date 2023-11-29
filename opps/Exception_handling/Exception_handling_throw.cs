using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Enter Age ");
            age = Convert.ToInt32(Console.ReadLine());
            try
            {
                throw new Exception("Age should be greater than or equal 18");
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter Age ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Eligible for vote " + age);
            }
            
            Console.ReadLine();
        }
    }
}

