using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Inheritance
{
    class Vehical
    {
        public string Make;
        public string Model;
    }
    class Car : Vehical
    {
        public int numDoors;
        public string fuelType;

        public void displayData()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Making Year :- " + Make);
            Console.WriteLine("Model Name :- " + Model);
            Console.WriteLine("Number of Doors :- " + numDoors);
            Console.WriteLine("Fute Type :- " + fuelType);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            Console.Write("Enter Designing year :- ");
            c.Make = Console.ReadLine();
            Console.Write("Enter Model :- ");
            c.Model = Console.ReadLine();
            Console.Write("Enter Doors Number :- ");
            c.numDoors = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fuel Type :- ");
            c.fuelType = Console.ReadLine();

            c.displayData();

            Console.ReadLine();
        }
    }
}
