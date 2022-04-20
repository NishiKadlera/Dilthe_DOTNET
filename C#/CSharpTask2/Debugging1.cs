using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class Debugging1
    {
        /// <summary>
        /// To read and didsplay 2D array
        /// </summary>
        public static void Main() //'M' instead m
        {
            int i, j;
            int[,] arr1 = new int[3, 3];//inserted ',' within square brackets for 2D array

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("-----------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");//added semicolon
            for (i = 0; i < 3; i++)//i=3
            {
                for (j = 0; j < 3; j++)//i=3
                {
                    Console.Write("element - [{0}] : ", i, j);//'C' is capital in console
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());//removed seperate brackets for i and j and added a comma
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i=0; i < 3; i++)//initialized i=0
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");//semicolon
        }
    }
}
