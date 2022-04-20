using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class Debugging2
    {
        /// <summary>
        /// Swapping
        /// </summary>
        public static void Main()
        {
            int a, b;
            //Get input from user
            Console.WriteLine("Enter value for a");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter value for b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Display swap
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            a = a / b;
            //a = a / b; not necessary, a=a/b should be once

            Console.Write("After swap a= " + b + " b= " + a);
            Console.WriteLine();
        }

    }
}
