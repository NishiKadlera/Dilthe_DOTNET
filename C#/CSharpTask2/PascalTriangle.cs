using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class PascalTriangle
    {
       /// <summary>
       /// constructing Pascal's triangle
       /// </summary>
        public static void Main()
        {
            Console.WriteLine("Let's construct the pascal triangle \n");
            //declaring variables
            int rows, i, j, k = 1, sp;
            Console.WriteLine("Enter the number of rows in triangle");
            rows= Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < rows; i++)
            {
                for(sp=1; sp<=rows-i; sp++)//for loop for spacing
                {
                    Console.Write(" ");
                }
                for(j=0; j<=i; j++)
                {
                    if(j==0 || i==0)
                    {
                        k = 1;
                    }
                    else
                    {
                        k = k * (i - j + 1) / j;//logic 
                    }
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
