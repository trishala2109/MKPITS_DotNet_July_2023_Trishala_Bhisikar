using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin="nagpur", destination, passengername, compartment,date;
            int trainno,dis=0;
            float totalfare;

            Console.WriteLine("Enter the Train are Origin :");
            origin=Console.ReadLine();

            Console.WriteLine("Enter the Train are Destination :");
            destination = Console.ReadLine();

            Console.WriteLine("Enter the Passenger Name :");
            passengername = Console.ReadLine();

            Console.WriteLine("Enter the Train Compartment (AC,Sleeper,Genral) :");
            compartment = Console.ReadLine();

            Console.WriteLine("Enter Train No. :");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Travalling Date :");
            date = Console.ReadLine();

            if(destination=="bhopal")
            {
                dis = 100;
            }
            else if(destination=="mumbai")
            {
                dis = 500;
            }
            else if(destination=="delhi")
            {
                dis = 800;
            }
            else
            {
                dis = 1000;
            }
            totalfare = dis * 10;
            Console.WriteLine("TotalFare =" + totalfare);

            Console.WriteLine("--------------------------------Ticket Details---------------------------------");
            Console.WriteLine("Train Origine :{0}\n Train Destination :{1}\n Passenger Name :{2}\n Compartment :{3}\n Train No.:{4}\n Travaling Date :{5}\n Total Ticket Amount ={6}", origin , destination , passengername , compartment , trainno , date , totalfare);
            Console.ReadKey();
        }
    }
}
