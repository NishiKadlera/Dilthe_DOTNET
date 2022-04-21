using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask3
{
    internal class SumParamsArray
    {
        /// <summary>
        /// Sum of natural numbers using params array
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Params Array\n*********************************");

            int size;
            Console.WriteLine("Enter the size of array");
            size =Convert.ToInt32(Console.ReadLine());

            int[] natural=new int[size];

            //To get the array elements from the user
            Console.WriteLine("Enter the values");
            for (int i = 0; i < natural.Length; i++)
            {
                natural[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine();
            Natural(natural);

        }


        public static void Natural(params int[] array)
        {
          
            //To display the sum of entered array elements
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"The sum of the elements in array is:{sum} ");
        }
    }
}
