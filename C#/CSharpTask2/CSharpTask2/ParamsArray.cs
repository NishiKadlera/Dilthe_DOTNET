using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    public class ParamsArray
    {
        public static void parray(params int[] a)
        {
            foreach (int i in a)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            Console.WriteLine("Params Array Concept");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            int size;
            Console.WriteLine("Please enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter the values");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in the array 'numbers' are:");
            parray(numbers);

        }
       
    }
}
