using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask2
{
    internal class JaggedArray
    {
        /// <summary>
        /// Jagged Array
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Jagged Array\n*******************************");
            //Declaring the variables---1D jagged array
            int[][] arr = new int[3][]
            {
                new int[2] { 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[4] { 6, 7, 8, 9 }
            };
            for (int i = 0; i < arr.Length; i++)//i<3
            {
                for (int j = 0; j < arr[i].Length; j++)//j<4
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }  

    }
}
