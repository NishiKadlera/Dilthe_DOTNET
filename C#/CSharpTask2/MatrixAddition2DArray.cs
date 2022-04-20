using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class MatrixAddition2DArray
    {
        /// <summary>
        /// Matrix addition in 2D array
        /// </summary>
        public static  void Main()
        {
            Console.WriteLine("MArtrix Addition\n*************************************");
            //declaring variables
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];

            //To accept the size of matrix from the user
            int size, i,j;
            Console.WriteLine("Enter the size of square matrix");
            size = Convert.ToInt32(Console.ReadLine());

            //To get the input for the first matrix from user
            Console.WriteLine("Enter the elements of 1st matrix ");            
            for(i = 0; i < size; i++)
            {
                for(j=0; j < size; j++)
                {
                    Console.WriteLine("element-[{0},{1}]",i,j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());             
                }
            }
            Console.WriteLine();

            //To get the input for the first matrix from user
            Console.WriteLine("Enter the elements of 2nd matrix ");
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Console.WriteLine("element-[{0},{1}]", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //To display the elements in the 1st matrix
            Console.WriteLine("First Matrix is:");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (j = 0; j < size; j++)
                    Console.Write(arr1[i, j] + "\t");
            }
            Console.WriteLine();


            //To display the elements in the 2nd matrix
            Console.WriteLine("Second Matrix is:");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (j = 0; j < size; j++)
                    Console.Write(arr2[i, j] + "\t");
            }
            Console.WriteLine();

            //Adding the matrix
            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];

            //Displaying the added matrix
            Console.WriteLine("Matrix Sum is:");
            for(i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (j = 0; j < size; j++)
                    Console.Write(arr3[i,j]+"\t");
            }
            Console.WriteLine();

        }
    }
}
