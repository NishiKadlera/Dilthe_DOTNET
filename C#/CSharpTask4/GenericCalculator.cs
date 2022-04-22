using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask4
{
    
    public class Generic<T>
    {

        public T Add(T a, T b)
        {
            return (dynamic) a+b;

        }
        public T Sub(T a, T b)
        {
            return (dynamic)a - b;

        }
        public T Mult(T a, T b)
        {
            return (dynamic)a * b;

        }
        public T Div(T a, T b)
        {
            return (dynamic)a / b;

        }
    }
    internal class GenericCalculator
    {
        public static void Main()
        {
            Generic<int> generic = new Generic<int>();
            Generic<double> generic1 = new Generic<double>();


            int num1, num2, choice = 0;
            string c;
            Console.WriteLine("Calculator\n**************************");

            do
            {

                Console.WriteLine("\nSelect the operation you want to perform from the below list: \nAddition\nSubtraction\nMultiplication\nDivision\n");

                Console.WriteLine("Enter 1 for Addition, Enter 2 for Substraction, Enter 3 for Multiplication,Enter 4 for Division ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("***************Addition**************\n");
                        Console.WriteLine("Enter First number");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        int result = generic.Add(num1, num2);
                        Console.WriteLine("\nSum of two number is: {0}", result);
                        break;

                    case 2:
                        Console.WriteLine("***************Subtraction**************\n");
                        Console.WriteLine("Enter First number");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        int result1 = generic.Sub(num1, num2);
                        Console.WriteLine("\nDifference of two number is: {0}", result1);
                        break;

                    case 3:
                        Console.WriteLine("***************Multiplication**************\n");
                        Console.WriteLine("Enter First number");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        int result2 = generic.Mult(num1, num2);
                        Console.WriteLine("\nProduct of two number is: {0}", result2);
                        break;

                    case 4:
                        Console.WriteLine("***************Division**************\n");
                        Console.WriteLine("Enter First number");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        double result3 = generic1.Div(num1, num2);
                        Console.WriteLine("\nQuotient of two number is: {0}", result3);
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice entered");
                        break;
                }

                Console.WriteLine("\nDo you want to perform further operations?\n");
                Console.WriteLine("Enter Yes to continue with other operations or No to stop\n*********************************");
                c = Console.ReadLine();
            }
            while (c == "Yes" || c == "yes");
 

        }

    }
}
