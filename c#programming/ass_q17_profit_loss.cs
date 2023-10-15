using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q17_profit_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costprice, sellingprice, total;
            Console.Write("Enter Cost price :");
            costprice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Selling price :");
            sellingprice = Convert.ToInt32(Console.ReadLine());


            total = sellingprice - costprice;

            if (sellingprice > costprice)
            {
                Console.WriteLine("You can book your profit amount:" + total);
            }
            else if (sellingprice < costprice)
            {
                Console.WriteLine("You can book your loss amount:" + total);
            }
            else
            {
                Console.WriteLine("no loss no profit");
            }

            Console.ReadLine();
        }
    }
}
