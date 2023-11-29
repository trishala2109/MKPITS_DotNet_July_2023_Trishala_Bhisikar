using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_overflowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            Console.WriteLine("Enter Age ");
            Age = Convert.ToInt32(Console.ReadLine());

            try
            {
                throw new Exception ("Age should be greater than or equal to 18 ");
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.ToString());
                Console.WriteLine("Enter Age");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter Age ");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Your eligibale for vote " + Age);
            }
            Console.ReadLine();
        }
    }
}
