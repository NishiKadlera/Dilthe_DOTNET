using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class Sum1DArray
    {
        public static void Main()
        {
            int size;
            int sum=0, i;
            Console.WriteLine("Give the size of array");
            size =Convert.ToInt32(Console.ReadLine());

            int[] arr=new int[size];
            //to get input from user
            Console.WriteLine("Enter the values");
            for (i = 0; i < arr.Length;i++)         
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum+= arr[i];//logic to add the numbersd
            }
            Console.WriteLine($"Sum of natural number is: {sum}");


        }
    }
}
