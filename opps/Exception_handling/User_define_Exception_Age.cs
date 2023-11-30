using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_define_Exception_Age
{
    class AgeException:ApplicationException
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    public class Age
    {
        int age = 12;
        public void AgeShow()
        {
            if(age <= 18)
            {
                throw (new AgeException("Age is greater than 18"));
            }
            else
            {
                Console.WriteLine("Age :" + age);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Age ag = new Age();
            try
            {
                ag.AgeShow();
            }
            catch(AgeException AE)
            {
                Console.WriteLine(AE.Message);
            }
            
            Console.ReadKey();
        }
    }
}
