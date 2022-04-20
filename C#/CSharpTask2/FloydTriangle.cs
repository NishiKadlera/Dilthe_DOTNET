using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class FloydTriangle
    {
        public static void Main()
        {
            Console.WriteLine("Floyd Triangle\n*************************************");
            int rows, i, j, k=1;
            Console.WriteLine("Enter the number of rows in triangle");
            rows=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(i=1; i<=rows; i++)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
               
        }
    }
}
