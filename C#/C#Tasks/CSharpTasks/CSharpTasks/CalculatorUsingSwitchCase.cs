using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    /// <summary>
    /// creating a calculator using switch cases
    /// </summary>
    internal class CalculatorUsingSwitchCase
    {

        //method
        public static void Main()
        {
            //declare the variable
            int num1, num2;
            double result;
            int option;
            //to get input from the user
            Console.WriteLine("Enter First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Select the operation you want to perform\n");

            Console.WriteLine("Enter 1 for Addition, Enter 2 for Substraction, Enter 3 for Multiplication,Enter 4 for Division ");
            option = Convert.ToInt32(Console.ReadLine());

            //perform operation using switch case
            switch (option)
            {
               case 1:
                    Console.WriteLine("-------------Addition-------------");
                    result= num1 + num2;
                    Console.WriteLine("Sum of two number is: {0}", result);
                    break;

               case 2:
                    Console.WriteLine("-------------Substraction-------------");
                    result = num1 - num2;
                    Console.WriteLine("Difference of two number is: {0}", result);
                    break;
                case 3:
                    Console.WriteLine("-------------Multiplication-------------");
                    result = num1 * num2;
                    Console.WriteLine("Multiplication of two number is: {0}", result);
                    break;
                case 4:
                    Console.WriteLine("-------------Division-------------");
                    result = num1 / num2;
                    Console.WriteLine("Division of two number is: {0}", result);
                    break;
                default:
                    Console.WriteLine("Can not find result");
                    break;



            }


        }
    }
}
