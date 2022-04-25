using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Show the working of multiple catch.
namespace CSharpTask6
{
    internal class MultipleCatch
    {
        /// <summary>
        /// Multiple catch
        /// </summary>
        public static void Main()//main method
        {
            int num1, num2, num;//declaring variables
            Console.WriteLine("******TRY CATCH-MULTIPLE CATCH*******");
            //try block
            try
            {
                Console.WriteLine("Enter first number:");
                num1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                num = num1 / num2;
                Console.WriteLine($"{num1}/{num2}={num}");
            }
            catch(DivideByZeroException dbze)//catch block 1
            {
                Console.WriteLine(dbze.Message);
            }
            catch (FormatException fe)//catch block 2
            {
                Console.WriteLine("Please enter integers only");
            }
            Console.ReadKey();
        }
    }
}
