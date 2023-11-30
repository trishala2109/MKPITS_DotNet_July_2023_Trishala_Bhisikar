using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace user_define_exception
{
    class TempretureException:ApplicationException
    {
        public TempretureException(string msg):base (msg)
        {

        }
    }
    class Tempreture
    {
        int temp = 0;
        public void TempreturShow()
        {
            if (temp == 0)
            {
                throw (new TempretureException ("zero tempreture found"));
            }
            else
            {
                Console.WriteLine("Tempreture :" +temp);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tempreture temp = new Tempreture();

            try
            {
                temp.TempreturShow();
            }
            catch(TempretureException E)
            {
                Console.WriteLine("TempretureException  {0}", E.Message);
            }
            Console.ReadKey();
        }
    }
}
