using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask4
{

    /// <summary>
    /// Calculate the Electricity bill for a month
    /// </summary>
    public abstract class ElectricityAbstraction
    {

        /// <summary>
        /// Abstract method
        /// </summary>
        public abstract void GetBill();

        /// <summary>
        /// Derived class
        /// </summary>
        public class Electricity1 : ElectricityAbstraction
        {
            //declaring the variaables 
            string name;
            int units = 0, charge = 0;
            public override void GetBill()
            {

                Console.WriteLine("Electricy Bill Calculation\n**********************************");

                //getting input from the user for electricty bill
                Console.WriteLine($"Enter person name:");
                name = Console.ReadLine();

                Console.WriteLine($"\nEnter the units used by {name} in the month of April");
                units = Convert.ToInt32(Console.ReadLine());

                if (units <= 100)
                {
                    charge = units * 1;
                    Console.WriteLine($"\n{name}'s electricity bill for the month of April is: {charge}");
                }
                else if (units <= 200)
                {
                    charge = (100 * 1) + (units - 100) * 5;
                    Console.WriteLine($"\n{name}'s electricity bill for the month of April is: {charge}");
                }
                else if (units <= 300)
                {
                    charge = (100 * 1) + (100 * 5) + (units - 100) * 10;
                    Console.WriteLine($"\n{name}'s electricity bill for the month of April is: {charge}");

                }
                else if (units > 300)
                {
                    charge = (100 * 1) + (100 * 5) + (100 * 10) + (units - 100) * 15;
                    Console.WriteLine($"\n{name}'s electricity bill for the month of April is: {charge}");
                }
                Console.WriteLine();
            }


        }

        public class Abstraction
        {
            public static void Main()
            {
                ElectricityAbstraction eb = new Electricity1();
                eb.GetBill();
            }
        }
    }





}
