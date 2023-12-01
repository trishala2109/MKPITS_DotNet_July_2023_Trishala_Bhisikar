using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_calcultor
{
    class Calculator
    {
        public double Result { get; set; }
        public void Addition(double Num1,double Num2)
        {
            Result = Num1+Num2;
        }
        public void Subtraction(int Num1, int Num2)
        {
           Result=Num1-Num2 ;
        }
        public void Multiply(int Num1, int Num2)
        {
            Result=Num1*Num2;
        }
        public void Division(int Num1, int Num2)
        {
            if(Result != 0)
            {
               Result = Num1 / Num2;
            }
            else
            {
                Console.WriteLine("Error Cannote divide by zero");
            }
        }
        public void Clear()
        {
            Result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Number 1 ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Operator (+,-,*,/) ");
                    string Operator = Console.ReadLine();


                    switch (Operator)
                    {
                        case "+":
                            c.Addition(num1, num2);
                            break;

                        case "-":
                            c.Subtraction(num1, num2);
                            break;

                        case "*":
                            c.Multiply(num1, num2);
                            break;

                        case "/":
                            c.Division(num1, num2);
                            break;

                        default:
                            c.Clear();
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    Console.WriteLine("Result : " + c.Result);
                }
            }
            Console.ReadLine();
        }
    }
}

