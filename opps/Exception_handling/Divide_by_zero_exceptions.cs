using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_zero_exceptions
{
    class DivNumber
    {
       
        public void Divide(int num1, int num2)
        {
            int Result = 0;
            try
            {
                Result = num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(Result);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DivNumber d = new DivNumber();
            d.Divide(25, 0);
            Console.ReadKey();
;        }
    }
}
