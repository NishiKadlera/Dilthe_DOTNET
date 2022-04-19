using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    /// <summary>
    /// Sum of natural numbers using while loop
    /// </summary>
    internal class SumOfNaturalNumbers
    {
        public static void Main()
        {
            int count;
            Console.WriteLine(" Enter the count of natural numbers");
            count = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int sum = 0;
            while (i <= count)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"Sum of natural number is: {sum}");


        }
    }
}
