using System;
namespace ass_q18_electric_bill
{
    class Bill
    {
        public static void Main(string[] args)
        {
            int CID, unit;
            string name;
            float total, surchrg = 0, finalamt = 0, chrgpunit = 0;

            Console.WriteLine("\n ------------ ENTER ELECTRICITY BILL DETAILS ------------ \n");
            Console.Write("Enter Customer ID: ");
            CID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            name = Console.ReadLine();
            Console.Write("Unit Consumed: ");
            unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ------------ BILL PAID DETAILS ------------ \n");

            {
                if (unit < 200)
                {
                    chrgpunit = 1.20f;
                }

                else if (unit >= 200 && unit < 400)
                {
                    chrgpunit = 1.50f;
                }

                else if (unit >= 400 && unit < 600)
                {
                    chrgpunit = 1.80f;
                }
                else
                {
                    chrgpunit = 2.00f;
                }

                total = unit * chrgpunit;

                Console.WriteLine("Customer ID: {0} \nCustomer Name: {1} \nUnit Consumed: {2}", CID, name, unit);
                Console.WriteLine("Amount Charges @Rs." + chrgpunit + " per unit: Rs." + total);

            }

            if (total >= 400)
            {
                surchrg = total * 0.15f;
            }

            finalamt = total + surchrg;

            Console.WriteLine("Surchage Amount: Rs.{0} \nNet Amount Paid By the Customer: Rs.{1} ", surchrg, finalamt);
            Console.ReadKey();
        }
    }
}


